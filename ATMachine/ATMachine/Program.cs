using System;

namespace ATMachine
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int balance;
            int pin;
            
            string yn;

            DateTime dateTime = DateTime.UtcNow.Date;

            balance = 2050;

            //pin
            Console.WriteLine("ATM MACHINE");
            Console.WriteLine("");
            Console.WriteLine("Please enter in your pin:");
           
       
            pin = int.Parse(Console.ReadLine());

            if (pin == 1234)
            {
                Console.WriteLine("");
                Console.WriteLine("Available Balance:" + " " + "£" + balance);
                Console.WriteLine("");
                Console.WriteLine("OPTIONS:");
                string[] options = new string[3];
                options[1] = "1.Withdraw";
                options[2] = "2.Deposit";

                for (int x = 0; x < options.Length; x++)
                {
                    Console.WriteLine(options[x]);
                }

                Console.WriteLine("Please type in the number of Withdraw or Deposit.");
                int input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    Withdraw();
                }
                if (input == 2)
                {
                    Deposit();
                }
               
                
            }
            else
            {
                Console.WriteLine("The Pin that you have entered is incorrect!!");
                Console.WriteLine("Please try again later.");
            }




            void Withdraw()
            {
                Console.WriteLine("");
                Console.WriteLine("WITHDRAW");

                string[] withdrawValues = new string[6];
                withdrawValues[0] = "1.£10";
                withdrawValues[1] = "2.£20";
                withdrawValues[2] = "3.£30";
                withdrawValues[3] = "4.£40";
                withdrawValues[4] = "5.£50";
                withdrawValues[5] = "6.Other amount";
                for(int i = 0; i < withdrawValues.Length; i++)
                {
                    Console.WriteLine(withdrawValues[i]);

                }

                Console.WriteLine("Please enter in the number option 1-6");
                int wInput = int.Parse(Console.ReadLine());

                if (wInput == 1)
                {
                    Console.WriteLine("Are you sure you would like to withdraw £10?");
                    Console.WriteLine("yes/no?");
                     yn = Console.ReadLine(); ;

                    if (yn == "yes")
                    {
                        int tenner = balance - 10;
                        Console.WriteLine("Your remainding balance is"+ " " + "£" + tenner);
                        
                        //cut
                        Console.WriteLine("Would you like a receipt?");
                        Console.WriteLine("yes/no?");
                        yn = Console.ReadLine();
                        if(yn == "yes")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("RECEIPT");
                            Console.WriteLine("Remainding Balance:" + " " + "£" + tenner);
                            Console.WriteLine(dateTime.ToString("dd/MM/yyyy"));
                            Console.WriteLine(dateTime.ToString("hh:mm:ss"));
                            Console.WriteLine("");
                            Console.WriteLine("Thank you for using the ATM Machine");
                            Console.WriteLine("Please wait for your cash");

                        }
                        if (yn == "no")
                        {
                            Console.WriteLine("Thank you for your time");
                            Console.WriteLine("Please wait for your cash");
                        }

                    }
                    
                }

                if (wInput == 2)
                {
                    Console.WriteLine("Are you sure you would like to withdraw £20?");
                    Console.WriteLine("yes/no?");
                    yn = Console.ReadLine(); 

                    if (yn == "yes")
                    {
                        int twenty = balance - 20;
                        Console.WriteLine("Your remainding balance is" + " " + "£" + twenty);

                        Console.WriteLine("Would you like a receipt?");
                        Console.WriteLine("yes/no?");
                        yn = Console.ReadLine();
                        if (yn == "yes")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("RECEIPT");
                            Console.WriteLine("Remainding Balance:" + " " + "£" + twenty);
                            Console.WriteLine(dateTime.ToString("dd/MM/yyyy"));
                            Console.WriteLine(dateTime.ToString("hh:mm:ss"));
                            Console.WriteLine("");
                            Console.WriteLine("Thank you for using the ATM Machine");
                            Console.WriteLine("Please wait for your cash");

                        }

                        if (yn == "no")
                        {
                            Console.WriteLine("Thank you for your time");
                            Console.WriteLine("Please wait for your cash");
                        }
                    }
                   
                   


                }
                if (wInput == 3)
                {
                    Console.WriteLine("Are you sure you would like to withdraw £30?");
                    Console.WriteLine("yes/no?");
                     yn = Console.ReadLine(); 

                    if (yn == "yes")
                    {
                        int thirty = balance - 30;
                        Console.WriteLine("Your remainding balance is" + " " + "£" + thirty);
                        Console.WriteLine("Would you like a receipt?");
                        Console.WriteLine("yes/no?");
                        yn = Console.ReadLine();
                        if (yn == "yes")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("RECEIPT");
                            Console.WriteLine("Remainding Balance:" + " " + "£" + thirty);
                            Console.WriteLine(dateTime.ToString("dd/MM/yyyy"));
                            Console.WriteLine(dateTime.ToString("hh:mm:ss"));
                            Console.WriteLine("");
                            Console.WriteLine("Thank you for using the ATM Machine");
                            Console.WriteLine("Please wait for your cash");

                        }
                        if (yn == "no")
                        {
                            Console.WriteLine("Thank you for your time");
                            Console.WriteLine("Please wait for your cash");

                        }
                    }

                    

                }
                if (wInput == 4)
                {
                    Console.WriteLine("Are you sure you would like to withdraw £40?");
                    Console.WriteLine("yes/no?");
                    yn = Console.ReadLine();

                    if (yn == "yes")
                    {
                        int fourty = balance - 40;
                        Console.WriteLine("Your remainding balance is" + " " + "£" + fourty);
                        Console.WriteLine("Would you like a receipt?");
                        Console.WriteLine("yes/no?");
                        yn = Console.ReadLine();
                        if (yn == "yes")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("RECEIPT");
                            Console.WriteLine("Remainding Balance:" + " " + "£" + fourty);
                            Console.WriteLine(dateTime.ToString("dd/MM/yyyy"));
                            Console.WriteLine(dateTime.ToString("hh:mm:ss"));
                            Console.WriteLine("");
                            Console.WriteLine("Thank you for using the ATM Machine");
                            Console.WriteLine("Please wait for your cash");

                        }

                        if (yn == "no")
                        {
                            Console.WriteLine("Thank you for your time");
                            Console.WriteLine("Please wait for your cash");
                        }
                    }

                   
                    
                }

                if (wInput == 5)
                {
                    Console.WriteLine("Are you sure you would like to withdraw £50?");
                    Console.WriteLine("yes/no?");
                    yn = Console.ReadLine();

                    if (yn == "yes")
                    {
                        int fifty = balance - 50;
                        Console.WriteLine("Your remainding balance is" + " " + "£" + fifty);
                        Console.WriteLine("Would you like a receipt?");
                        Console.WriteLine("yes/no?");
                        yn = Console.ReadLine();
                        if (yn == "yes")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("RECEIPT");
                            Console.WriteLine("Remainding Balance:" + " " + "£" + fifty);
                            Console.WriteLine(dateTime.ToString("dd/MM/yyyy"));
                            Console.WriteLine(dateTime.ToString("hh:mm:ss"));
                            Console.WriteLine("");
                            Console.WriteLine("Thank you for using the ATM Machine");
                            Console.WriteLine("Please wait for your cash");

                        }
                        if (yn == "no")
                        {
                            Console.WriteLine("Thank you for your time");
                            Console.WriteLine("Please wait for your cash");
                        }

                    }

                }
                if (wInput == 6)
                {
                    Console.WriteLine("Please enter the amount you would like to withdraw:");
                    Console.WriteLine("Must be multiples of 5");
                    int own = int.Parse(Console.ReadLine());

                    if (own % 5 == 0)
                    {
                        own = balance - own;
                        Console.WriteLine("Your Remainding Balance is" + " "+ "£" + own);
                        Console.WriteLine("Would you like a receipt?");
                        Console.WriteLine("yes/no?");
                        yn = Console.ReadLine();
                        if (yn == "yes")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("RECEIPT");
                            Console.WriteLine("Remainding Balance:" + " " + "£" + own);
                            Console.WriteLine(dateTime.ToString("dd/MM/yyyy"));
                            Console.WriteLine(dateTime.ToString("hh:mm:ss"));
                            Console.WriteLine("");
                            Console.WriteLine("Thank you for using the ATM Machine");
                            Console.WriteLine("Please wait for your cash");

                        }
                        if (yn == "no")
                        {
                            Console.WriteLine("Thank you for your time");
                            Console.WriteLine("Please wait for your cash");
                        }
                    }

                }
               



            }

            void Deposit()
            {
                Console.WriteLine("");
                Console.WriteLine("How much would you like to deposit?");
                int deposit = int.Parse(Console.ReadLine());
                Console.WriteLine("You have deposited:" + " " + "£" + deposit);
                Console.WriteLine("Are you sure you want to deposit £" + deposit);
                Console.WriteLine("yes/no?");
                yn = Console.ReadLine();

                if (yn == "yes")
                {
                    int result = balance + deposit;
                    Console.WriteLine("Your balance is now:"+" "+"£"+result);
                    Console.WriteLine("Would you like a receipt?");
                    Console.WriteLine("yes/no?");
                    yn = Console.ReadLine();
                    if (yn == "yes")
                    {
                        Console.WriteLine("");
                        Console.WriteLine("RECEIPT");
                        Console.WriteLine("Remainding Balance:" + " " + "£" + result);
                        Console.WriteLine(dateTime.ToString("dd/MM/yyyy"));
                        Console.WriteLine(dateTime.ToString("hh:mm:ss"));
                        Console.WriteLine("");
                        Console.WriteLine("Thank you for using the ATM Machine");
                        Console.WriteLine("Please wait for your cash");

                    }
                    if (yn == "no")
                    {
                        Console.WriteLine("Thank you for your time");
                        Console.WriteLine("Please wait for your cash");
                    }
                }
            }




        }
       
    }
}
