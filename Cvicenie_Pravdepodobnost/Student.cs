using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_Pravdepodobnost
{
    public class Student
    {
        public string Id { get; set; }
        public int TicketCount { get; set; }

        public Student(string id, int ticketCount)
        {
            Id = id;
            TicketCount = ticketCount;
        }
    }
}
