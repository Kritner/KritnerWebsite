using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using KritnerWebsite.Interfaces;
using KritnerWebsite.Services;
using AutoMapper;
using KritnerWebsite.Models.HomeViewModels;
using System.Net;

namespace KritnerWebsite.Controllers
{
    [Authorize]
    [Route("api/blog")]
    public class BlogController : Controller
    {
        const string _BLOG_URL = "http://kritner.blogspot.com/feeds/posts/default?alt=rss";

        private readonly ILogger<BlogController> _logger;
        private readonly IBlogRetrieval _blogService;

        public BlogController(ILogger<BlogController> logger, IBlogRetrieval blogService)
        {
            _logger = logger;
            _blogService = blogService;
        }

        [HttpGet]
        public async Task<JsonResult> Get()
        {

            try
            { 
                var blogs = await _blogService.GetBlogEntries(_BLOG_URL);

                return Json(
                    Mapper.Map<IEnumerable<BlogEntryViewModel>>(blogs)
                );
            }
            catch (Exception)
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return Json("Error occurred retrieving blog entries");
            }
        }
    }
}
