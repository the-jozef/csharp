using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_metody
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Adress { get; set; }

        public char Gender { get; set; }

        
        public bool Isadult()
        {
            if (Age > 18)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public string Test ()
        {
           string a = Name + Age + Adress + Gender;
            return a;  
        }





    
    }
}
