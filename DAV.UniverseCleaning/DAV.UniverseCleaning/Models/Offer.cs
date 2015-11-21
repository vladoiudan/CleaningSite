using System;

namespace DAV.UniverseCleaning.Models
{
    public class Offer
    {
        public Offer(string title,string details)
        {
            this.Title = title;
            this.Details = details;
        }
        public string Title { get; set; }
        public string Details { get; set; }
    }
}