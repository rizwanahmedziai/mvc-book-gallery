using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCMovieGallery.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public string Description { get; set; }
        public Artist[] Artists { get; set; }
        public bool Favourite { get; set; }
    }
}