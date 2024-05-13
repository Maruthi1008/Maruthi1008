using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.SqlClient;
using System.Configuration;

namespace ConsoleApp2
{
    class Program
    {

        static int id = 460879654;
        static int availableseats = 2;
        static int upperbirth = 0;
        static int lowerbirth = 0;
        static int middlebirth = 0;
        static int sidelower = 0;
        static int sideupper = 0;
        static int racavailable = 0;
        static int waitinglist = 2;

        static int rac = 1;
        static int upper = 3;
        static int middle = 2;
        static int lower = 1;
        static int slower = 7;
        static int supper = 8;
        static int waiting = 0;

        public static void Main(string[] args)
        {


            while (true)
            {
                Console.WriteLine("---Ticket Booking System---\n 1.Book Ticket\n 2.View Ticket\n 3.Available tickets\n 4.Exit ");

                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Bookticket();
                        break;
                    case 2:
                        Class1.Viewtickets();
                        break;
                    case 3:
                        availabletickets();
                        break;

                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }

        }
        public static void availabletickets()
        {
            Console.WriteLine("Available tickets             :" + availableseats);
            Console.WriteLine("UPPER Available tickets       :" + upperbirth);
            Console.WriteLine("LOWER Availble tickets        :" + lowerbirth);
            Console.WriteLine("Middle Availble tickets       :" + middlebirth);
            Console.WriteLine("Side Lower Availble tickets   :" + sidelower);
            Console.WriteLine("Side Upper Availble ticket    :" + sideupper);
            Console.WriteLine("Rac Availble tickets          :" + racavailable);
            Console.WriteLine("Waiting list Availble tickets :" + waitinglist);
        }

        public static void Bookticket()
        {
            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Age:");
            string age = Console.ReadLine();


            Console.WriteLine("Enter Birth: 1.UPPER 2.MIDDLE 3.LOWER 4.SIDE LOWER 5.SIDE UPPER");
            string birth = Console.ReadLine();

            if (availableseats == 0)
            {
                Console.WriteLine("Regret");
            }
            else if (birth == ("UPPER") && upperbirth > 0)
            {

                upperbirth--;
                availableseats--;
                id++;
                Console.WriteLine("Upper " + upper + " birth booked ;");
                Class1.bookticket1(id, name, age, birth + " " + upper);
                upper = upper + 3;

            }
            else if (birth == ("LOWER") && lowerbirth > 0)
            {
                lowerbirth--;
                availableseats--;
                id++;
                Console.WriteLine("Lower " + lower + " birth booked ;");
                Class1.bookticket1(id, name, age, birth + " " + lower);
                lower = lower + 3;

            }
            else if (birth == ("MIDDLE") && middlebirth > 0)
            {
                middlebirth--;
                availableseats--;
                id++;
                Console.WriteLine(" Middle " + middle + " birth booked ;");
                Class1.bookticket1(id, name, age, birth + " " + middle);
                middle = middle + 3;
            }
            else if (birth == ("SIDE LOWER") && sidelower > 0)
            {
                sidelower--;
                availableseats--;
                id++;
                Console.WriteLine(" Side Lower " + slower + " birth booked ;");
                Class1.bookticket1(id, name, age, birth + " " + slower);
                slower = slower + 8;

            }
            else if (birth == ("SIDE UPPER") && sideupper > 0)
            {
                sideupper--;
                availableseats--;
                id++;
                Console.WriteLine(" Side Upper " + supper + " birth booked ;");
                Class1.bookticket1(id, name, age, birth + " " + supper);
                supper = supper + 8;

            }
            else if (birth == ("UPPPER") && upperbirth > 0 || birth == ("MIDDLE") && middlebirth > 0 || birth == ("LOWER") && lowerbirth > 0 || birth == ("SIDE LOWER") && sidelower > 0 || birth == ("SIDE UPPER") && sideupper > 0 || racavailable > 0 || waitinglist > 0)
            {
                if (upperbirth > 0)
                {
                    availableseats--;
                    upperbirth--;
                    id++;
                    Console.WriteLine("Upper " + upper + " birth booked ;");
                    Class1.bookticket1(id, name, age, birth + " " + upper);

                    upper = upper + 3;
                }
                else if (middlebirth > 0)
                {
                    availableseats--;
                    middlebirth--;
                    id++;
                    Console.WriteLine("Middle " + middle + " birth booked ;");
                    Class1.bookticket1(id, name, age, birth + " " + middle);
                    middle = middle + 3;
                }
                else if (lowerbirth > 0)
                {
                    availableseats--;
                    lowerbirth--;
                    id++;
                    Console.WriteLine("Lower " + lower + " birth booked ;");
                    Class1.bookticket1(id, name, age, birth + " " + lower);
                    lower = lower + 3;

                }
                else if (sidelower > 0)
                {
                    availableseats--;
                    sidelower--;
                    id++;


                    Console.WriteLine("Side Lower " + slower + " birth booked ;");
                    Class1.bookticket1(id, name, age, birth + " " + slower);
                    slower = slower + 8;

                }
                else if (sideupper > 0)
                {
                    availableseats--;
                    sideupper--;
                    id++;


                    Console.WriteLine("Side Upper" + supper + " birth booked ;");
                    Class1.bookticket1(id, name, age, birth + " " + supper);
                    supper = supper + 8;

                }
                else if (racavailable > 0)
                {
                    racavailable--;
                    availableseats--;
                    id++;

                    birth = "RAC";
                    Console.WriteLine("Rac " + rac + " Booked");
                    Class1.bookticket1(id, name, age, birth + " " + rac);
                    rac++;

                }
                else if (waitinglist > 0)
                {
                    waitinglist--;
                    availableseats--;
                    id++;
                    waiting++;
                    birth = "Waiting List";
                    Console.WriteLine("Waiting list " + waiting + "");
                    Class1.bookticket1(id, name, age, birth + " " + waiting);
                }
                else if (availableseats < 0)
                {

                    Console.WriteLine("Regret");
                }

                
            }
        }
    }
}

