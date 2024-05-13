using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp2
{
    class Class1
    {


        static ArrayList Bookedtickets = new ArrayList();
        public static void bookticket1(int id,string name, string age, string birth)
        {
            
            string[] booklist = { $"PNR: {id} Name: {name} Age: {age} Birth: {birth}" };
            Bookedtickets.AddRange(booklist);
        
        }
       
        public static void Viewtickets()
        {

            Console.WriteLine("---BOOKED TICKET LIST---");
            foreach(var i in Bookedtickets)
            {
                Console.WriteLine(i);
               
            }
        }
       
    }
}
