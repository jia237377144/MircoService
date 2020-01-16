using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;

namespace JLP.DNC.Test
{
    class Program
    {
        static void Main(string[] args)
        {

            Type type = typeof(Person);

            var properties = type.GetProperties().Where(p => p.PropertyType.IsSubclassOf(type));
            foreach (var propInfo in properties)
            {
                Console.WriteLine(propInfo.Name);
            }

            Console.WriteLine("Please Enter");

            Console.ReadLine();

        }
    }

    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Person Child { get; set; }
    }




}
