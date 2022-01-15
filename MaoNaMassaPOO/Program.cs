using System;
using System.Collections.Generic;
using MaoNaMassaPOO.ContentContext;
using MaoNaMassaPOO.ContentContext.Enums;

namespace MaoNaMassaPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Articles>();
            articles.Add(new Articles(title:"Article xpto", url: "article-xpto"));
            articles.Add(new Articles(title:"Article DotNet", url: "article-dotnet"));
            articles.Add(new Articles(title:"Article C#", url: "article-csharp"));
            articles.Add(new Articles(title:"Article JS", url: "article-js"));

            foreach (var article in articles)
            {
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
            }

            Console.ReadKey();
        }
    }
}
