﻿namespace cookie_stand_api.Models
{
    public class HourlySale
    {
        public int Id { get; set; }
        public int Hour { get; set; }

        public int CookiestandId { get; set; }
        //public Cookiestand Cookiestand { get; set; }
    }
}
