using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaoNaMassaPOO.ContentContext
{
    public abstract class Content
    {
        public Content(string title, string url)
        {
            Title = title;
            Url = url;
            Id = Guid.NewGuid(); // SPOF - Single point of failure
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }

    }
}
