using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Model
{
    public class usertime
    {
        public string username { get; set; }
        public int start { get; set; }
        public int end { get; set; }
    }
}
