using System;

namespace _233590_lab_mid
{
    internal class Program
    {

        class studentclub
        {
            public string president { get; set; }
            public string general_secratory { get; set; }
            public string vicepresident { get; set; }
            public string finance_secratory { get; set; }
            public double budget { get; set; }


            private string society_name;
            private string society_description;
            private string society_head;
            private string society_assitanttl;

            public void registersociety()
            {
                string societyname;
                string societyhead;
                string atl;
                string description;

                Console.WriteLine("enter the society name :");
                societyname = Console.ReadLine();


                Console.WriteLine("enter name of team leader :");
                societyhead = Console.ReadLine();

                Console.WriteLine("enter name of atl :");
                atl = Console.ReadLine();

                Console.WriteLine("enter the purpose of scoiety :");
                description = Console.ReadLine();

                Console.WriteLine("new society is registerd of name :" + societyname + "\n team leader is :" + societyhead + "\n atl is :" + atl + "\n purpose is :" + description);




            }

            public void allocation_of_fund() {

                int choice;

                string tech_bit;
                string sports;
                string literary;
                string media_and_promotion;
                string arts_and_dramatics;

                Console.WriteLine("total fund is 1500$");

                Console.WriteLine("enter the name of society to allocate the fund ");

                Console.WriteLine("1 : tech_bit  \n 2 :  sports  \n 3 : literary  \n 4 :  media_and_promotion  \n 5:  arts_and_dramatics");

                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("fund for techbit is allocated as 600$");

                }
                else if (choice == 2)
                {
                    Console.WriteLine("fund for sports is allocated as 500$");
                }
                else if (choice == 3)
                {
                    Console.WriteLine("fund for literary is allocated as 300$");
                }
                else if (choice == 4)
                {
                    Console.WriteLine("media and promotion are non funded society");
                }
                else if (choice == 5) {
                    Console.WriteLine("arts and dramtics are non funded society");
                }
                else
                {
                    Console.WriteLine("invalid choice");
                };


            }
            public void register_event()
            {
                int n1;
                string eventt;

                Console.WriteLine("name of society for which you want to register event ");

                Console.WriteLine("1 : tech_bit  \n 2 :  sports  \n 3 : literary  \n 4 :  media_and_promotion  \n 5:  arts_and_dramatics");

                n1 = int.Parse(Console.ReadLine());


                Console.WriteLine("what will be in event");
                eventt = Console.ReadLine();

                Console.WriteLine("event registered hope we will have " + eventt);




            }
            public void funding_information(){

                int n2;
                string info;

                Console.WriteLine("name of society for which you want to see funding info ");

                Console.WriteLine("1 : tech_bit  \n 2 :  sports  \n 3 : literary  \n 4 :  media_and_promotion  \n 5:  arts_and_dramatics");

                n2 = int.Parse(Console.ReadLine());

                

                if (n2 == 1)
                {
                    Console.WriteLine("fund for techbit is 600$");

                }
                else if (n2 == 2)
                {
                    Console.WriteLine("fund for sports is 500$");
                }
                else if (n2 == 3)
                {
                    Console.WriteLine("fund for literary is 300$");
                }
                else if (n2 == 4)
                {
                    Console.WriteLine("media and promotion are non funded society");
                }
                else if (n2 == 5)
                {
                    Console.WriteLine("arts and dramtics are non funded society");
                }
                else
                {
                    Console.WriteLine("invalid choice");
                };






            }


        }
            static void Main(string[] args)

        {
         
            studentclub studentclub = new studentclub();

            ;



            int choice;

            Console.WriteLine("students club management system");
            Console.WriteLine("\n======================================\n");

            Console.WriteLine(" 1 register a new society \n 2 allocating funds \n 3 register event \n 4 display funding info \n 5 display event for society \n 6 exit ");

            Console.WriteLine("\n " +
                "enter choice to perform operations : ");
            choice = int.Parse(Console.ReadLine());
            do
            {
                switch (choice)
                {
                    case 1:

                        studentclub.registersociety();


                        break;
                    case 2:
                        studentclub.allocation_of_fund();
                        break;
                        case 3:
                        studentclub.register_event();
                        break;

                    case 4:
                        studentclub.funding_information();
                        break;

                    case 5:
                        Console.WriteLine("event are ");
                        break;
                    case 6:
                        Console.WriteLine("exiting press any key ");
                        break;
                }
            } while (choice > 0 && choice == 6);




            Console.ReadKey();
        }
    }
}
