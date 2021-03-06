﻿using System.Collections.Generic;

namespace WeGouSharp.Model
{
   public class Article
    {
        public string Url { get; set; }

        public List<string> Imgs { get; set; }

        public string Title { get; set; }

        /// <summary>
        /// 文章简介
        /// </summary>
        public string Brief { get; set; }

        public string Time { get; set; }
        // public string officialAccount;

        public string ArticleListUrl { get; set; }//???

        public OfficialAccount OfficialAccount { get; set; }
    }
}
