using KritnerWebsite.Models.HomeModels;
using KritnerWebsite.Models.HomeViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace KritnerWebsite.Services
{
    public class BlogRetrievalService : IBlogRetrieval
    {
        public async Task<IEnumerable<BlogEntry>> GetBlogEntries(string blogUrl)
        {
            List<BlogEntry> blogEntries = new List<BlogEntry>();

            try
            {
                HttpClient client = new HttpClient();
                Stream stream = await client.GetStreamAsync(blogUrl);
                XPathDocument xmlDocument = new XPathDocument(stream);

                XPathNavigator nav = xmlDocument.CreateNavigator();

                foreach (XPathNavigator node in nav.Select("rss/channel/item"))
                {
                    BlogEntry be = new BlogEntry();
                    be.Title = node.SelectSingleNode("title").Value;
                    be.Body = node.SelectSingleNode("description").Value;
                    be.BlogEntryLink = node.SelectSingleNode("link").Value;
                    be.EntryPostedDate = Convert.ToDateTime(node.SelectSingleNode("pubDate").Value);

                    blogEntries.Add(be);
                }
            }
            catch (Exception ex)
            {
                blogEntries.Clear();
                BlogEntry be = new BlogEntry();
                be.Title = "Blog entries cannot be retrieved.";
                be.Body = "Mayhaps your firewall is blocking the blogger domain?<br /><br />" +
                    "Exception thrown: <br />" +
                    ex.Message;
                be.EntryPostedDate = DateTime.Now;

                blogEntries.Add(be);
            }

            return blogEntries;
        }
    }
}
