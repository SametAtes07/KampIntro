﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaseLoggerServise : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı");


        }
    }

}
