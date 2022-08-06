using System;
using System.Collections.Generic;
using System.Web;

namespace GuidingLightBookGallery.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int PublicationYear { get; set; }
        public string PublishingHouse { get; set; }
        public string DescriptionHTML { get; set; }
        public Author[] Authors { get; set; }
        public string DisplayBookInfo
        {
            get
            {
                return Title + "published by" + PublishingHouse;
            }
        }
    }
}
