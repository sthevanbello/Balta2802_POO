﻿using MaoNaMassaPOO.NotificationContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaoNaMassaPOO.SharedContext;

namespace MaoNaMassaPOO.ContentContext
{
    public class CareerItem : Base
    {
        public CareerItem(int order, string title, string description, Course course)
        {
            Order = order;
            Title = title;
            Description = description;
            Course = course;
            if(course == null)
            {
                AddNotification(new Notification { 
                    Message = "Invalid course", 
                    Property = "course"
                });
            }
        }



        public int Order { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }

    }
}