using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA14_12_2019
{
    public class Ticket
    {
        static int CurrentId = 0;
        public int Id;
        public string Name;
        public DateTime DateTime;
        public int Count;
        public int AgeLimit;
        public Ticket()
        {
            Id = CurrentId++;
        }
        //public Ticket(string att, DateTime dateT)
        //{
        //    Id = Id++;
        //    Name = att;
        //    //DateT = dateT;
        //}
    }
    
}
