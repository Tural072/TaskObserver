﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskObserver
{
    public class CustomerWithSms : ICustomer
    {
        public string ProductName { get; set; }
        public void GetMessage()
        {
            Console.WriteLine("I am With Sms");
        }
    }
}