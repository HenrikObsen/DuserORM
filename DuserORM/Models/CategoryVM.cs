using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DuserORM
{
    public class CategoryVM
    {
        public Category category { get; set; }
        public List<Beer> beers { get; set; }
    }
}