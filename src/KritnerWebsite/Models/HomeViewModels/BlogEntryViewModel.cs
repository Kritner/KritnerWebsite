using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KritnerWebsite.Models.HomeViewModels
{
    public class BlogEntryViewModel
    {
        public string Title { get; set; }

        public string Body { get; set; }

        public string BlogEntryLink { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
        public DateTime EntryPostedDate { get; set; }
    }
}
