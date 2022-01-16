using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaoNaMassaPOO.ContentContext
{
    public class Career : Content
    {
        public Career(string title, string url) : base(title, url)
        {
            Items = new List<CareerItem>();
        }
        public IList<CareerItem> Items { get; }

        //public int TotalCourses {
        //    get
        //    {
        //        return Items.Count;
        //    }
        //}

        public int TotalCourses => Items.Count; 
        // Expression Body
    }
}
