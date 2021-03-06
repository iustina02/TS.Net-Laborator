﻿using System;
using System.ServiceModel;
//using System.ServiceModel.Description;
using ObjectWCF;


namespace HostWCF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lansare server WCF...");
            var host = new ServiceHost(typeof(ModelMyPhotos),new Uri("http://localhost:8000/PC"));
            foreach (var se in host.Description.Endpoints)
                    Console.WriteLine("A (address): {0} \nB (binding): {1} \nC(Contract): {2}\n",se.Address.ToString(), se.Binding.Name.ToString(), se.Contract.Name.ToString());
            host.Open();
            Console.WriteLine("Server in executie. Se asteapta conexiuni...");
            Console.WriteLine("Apasati Enter pentru a opri serverul!");
            Console.ReadKey();
            host.Close();
        }
    }

}
