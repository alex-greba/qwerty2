using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Globalization;

namespace CA14_12_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("go!");
            //List<Ticket> t = new List<Ticket>();
            //t.Add(new Ticket("Super8", new DateTime(2019, 12, 14, 12, 00, 00)));
            //t.Add(new Ticket("Super8", new DateTime(2019, 12, 14, 12, 00, 00)));
            //t.Add(new Ticket("Super8", new DateTime(2019, 12, 14, 12, 00, 00)));
            //t.Add(new Ticket("Super8", new DateTime(2019, 12, 14, 12, 00, 00)));
            //t.Add(new Ticket("Super8", new DateTime(2019, 12, 14, 13, 00, 00)));
            //t.Add(new Ticket("Super9", new DateTime(2019, 12, 14, 12, 00, 00)));
            //t.Add(new Ticket("Super9", new DateTime(2019, 12, 14, 12, 00, 00)));
            //t.Add(new Ticket("Super9", new DateTime(2019, 12, 14, 12, 00, 00)));
            //t.Add(new Ticket("Super9", new DateTime(2019, 12, 14, 12, 00, 00)));
            //t.Add(new Ticket("Super9", new DateTime(2019, 12, 14, 13, 00, 00)));
            var str = File.ReadAllText(@"D:\GAW\ticket.txt");
            var obj = JsonConvert.DeserializeObject<List<Ticket>>(str);

            do
            {
                Console.Write("Enter Date: ");
                string date = Console.ReadLine();
                Console.Write("Enter Time: ");
                string time =Console.ReadLine();
                Console.Write("Enter Ticket's Count: ");
                string count = Console.ReadLine();


                DateTime OrderDT = DateTime.ParseExact(date + " " + time, "yyyy:MM:dd HH:mm", CultureInfo.InvariantCulture);
                if (int.TryParse(count, out int OderCount)) { }
                else { }
                    
                
                foreach (Ticket t in obj.Where( t=> t.DateTime == OrderDT && t.Count <= OderCount))
                {
                        Console.WriteLine(t.Id + ". DateTime: " + t.DateTime + "AgeLimit: " + t.AgeLimit + "Name: " + t.Name);
               

                }
                //userInputId = redaline

                if (obj.First(c => c.Id == userInputId) != null)
                {

                }


                //string enter = Console.ReadLine();
                //int Age = Convert.ToInt32(enter);

            }
            while (true);


        }
    }
}
