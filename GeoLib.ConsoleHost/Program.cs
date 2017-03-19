﻿using GeoLib.Services;
using System;
using System.ServiceModel;

namespace GeoLib.ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost hostGeoManager = new ServiceHost(typeof(GeoManager));

            hostGeoManager.Open();

            Console.WriteLine("Service Started....");
            Console.ReadLine();

            hostGeoManager.Close();

        }
    }
}
