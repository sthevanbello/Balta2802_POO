using System;
using System.Collections.Generic;
using System.Linq;
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

            //foreach (var article in articles)
            //{
            //    Console.WriteLine("-----------------------------------------------");
            //    Console.WriteLine(article.Id);
            //    Console.WriteLine(article.Title);
            //    Console.WriteLine(article.Url);
            //}

            var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
            var courseDotNet = new Course("Fundamentos DotNet", "fundamentos-dotnet");
            var courseCsharp = new Course("Fundamentos C#", "fundamentos-csharp");
            var courseJs = new Course("Fundamentos JS", "fundamentos-JS");

            var courses = new List<Course>();
            courses.Add(courseOOP);
            courses.Add(courseDotNet);
            courses.Add(courseCsharp);
            courses.Add(courseJs);

            var careers = new List<Career>();
            var careerDotNet = new Career(title:"DotNet", url:"career-backend");

            var careerItem3 = new CareerItem(3, "Fundamentos C#", "Career Back End", courseCsharp);
            var careerItem2 = new CareerItem(2, "Fundamentos DotNet", "Career Back End", courseDotNet);
            var careerItem1 = new CareerItem(1, "Fundamentos OOP", "Career Back End", null);
            careerDotNet.Items.Add(careerItem2);
            careerDotNet.Items.Add(careerItem3);
            careerDotNet.Items.Add(careerItem1);
            careers.Add(careerDotNet);

            foreach (var career in careers)
            {
                Console.WriteLine("------------ Career --------------");
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(o => o.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title} - {item.Course?.Title}");
                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"Notification: {notification.Message}");
                    }
                }
            }

            

            Console.ReadKey();
        }
    }
}
