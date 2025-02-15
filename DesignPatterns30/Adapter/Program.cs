﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    { // başka teknolojiyi bizim projeye entegre edilmesinde kullanılır en. dem favori
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new Log4NetAdapter());
            productManager.Save();

            Console.ReadLine();
        }
    }

    class ProductManager
    {

        private ILogger _logger;

        public ProductManager(ILogger logger)
        {
            _logger = logger;
        }

        public void Save()
        {
            _logger.Log("User Data");
            Console.WriteLine("Saved");

        }
    }

    interface ILogger
    {
        void Log(string message);


    }

    class BDLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("BD LOGGED {0}",message);

        }
    }

    //Nuget ten indirildiğimizi varsayalım
    class Log4Net
    {
        public void LogMessage(string message)
        {
            Console.WriteLine("Logged with Log4net {0}",message);
        }

    }

    class Log4NetAdapter:ILogger
    {
        public void Log(string message)
        {
            Log4Net log4Net = new Log4Net();
            log4Net.LogMessage(message);
        }
    }

}
