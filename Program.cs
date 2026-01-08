namespace BankSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] owners = new string[100];
            string[] accounts = new string[100];
            string[] accounts2 = new string[100];
            double[] balances = new double[100];




            int LastAccountIndex = -1;

            owners[0] = "Alice";
            accounts[0] = "ACC0";
            balances[0] = 1000;
            LastAccountIndex++;

            owners[1] = "Bob";
            accounts[1] = "ACC1";
            balances[1] = 500;
            LastAccountIndex++;
            bool exit = false;
            while (true)
            {
                Console.WriteLine("Welcome to the Bank System");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Check Balance");
                Console.WriteLine("5. Transfer Money");
                Console.WriteLine("6. Exit");
                Console.Write("Please select an option: ");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        //Phase2: input &  //Phase3: processing
                        Console.Write("Enter your name: ");
                        owners[LastAccountIndex + 1] = Console.ReadLine();
                        Console.Write("Enter initial deposit amount: ");
                        balances[LastAccountIndex + 1] = double.Parse(Console.ReadLine());
                        accounts[LastAccountIndex + 1] = "ACC" + (LastAccountIndex + 1); //processing order

                        //Phase4: output
                        Console.WriteLine("Account created successfully!");
                        Console.WriteLine("Account Number: " + accounts[LastAccountIndex + 1]);

                        LastAccountIndex++;
                        break;
                    case 2:
                        Console.Write("Enter account number: ");
                        string accNumber = Console.ReadLine();
                        Console.Write("Enter deposit amount: ");

                        double depositAmount = double.Parse(Console.ReadLine());

                        bool accountFound = false;

                        for (int i = 0; i < 100; i++)
                        {
                            if (accNumber == accounts[i])
                            {
                                balances[i] += depositAmount;

                                accountFound = true;
                                break;
                            }

                        }
                        if (accountFound == false)
                        {
                            Console.WriteLine("account not found");
                        }
                        else
                        {
                            Console.WriteLine("Deposite succeefuly");
                        }
                        break;



                    case 3:
                        //Withdraw Money



                                //if (accounts[i] == storedAccountNumber)
                                //{
                                //    if (withdrawAmount <= storedBalance)
                                //    {
                                //        storedBalance -= balances[0];
                                //        Console.WriteLine("Please collect your cash:");
                                //        Console.WriteLine("Remaining balance:" + storedBalance);
                                //    }
                                //    else
                                //    {
                                //        Console.WriteLine("Insufficient balance");
                                //    }
                                //}
                                //else
                                //{
                                //    Console.WriteLine("Invaild account number");
                                //}
                                break;

                    case 4:
                        //check moey operation
                        Console.Write("Enter account number: ");
                        string accNumber2 = Console.ReadLine();

                        bool accountFound2 = false;
                        double currentBalance = 0;

                        for (int i = 0; i < 100; i++)
                        {
                            if (accNumber2 == accounts[i])
                            {
                                currentBalance = balances[i];
                                accountFound2 = true;
                               

                                break;
                            }

                        }

                        //output
                        if (accountFound2 == false)
                        {
                            Console.WriteLine("sorry account not found");
                        }

                        else
                        {
                           

                                Console.WriteLine("Your balance = " + currentBalance);
                           
                        }




                            break;
                    case 5:
                        //trasfar operation
                        //Console.WriteLine("Enter a sender account:");
                        //accounts[i] = Console.ReadLine();
                        //Console.WriteLine("Enter a reciever account:");
                        //accounts2[i] = Console.ReadLine();
                        //Console.WriteLine("Enter a mount that you want to send:");
                        //double amount2=double.Parse(Console.ReadLine());


                        //if (accounts[i] == storedAccountNumber)
                        //{
                        //    if (accounts2[i] == storedAccountNumber1)
                        //    {
                        //        if (storedBalance >= amount2)
                        //        {
                        //            storedBalance -= amount2;
                        //            storedBalance2 += amount2;
                        //            Console.WriteLine(" reciever has recieved additional balance:" + storedBalance2);
                        //            Console.WriteLine(" sender done sending  balance:" + storedBalance);
                        //        }


                        //        else
                        //        {
                        //            Console.WriteLine("Insufficient balance.");
                        //        }



                        //    }
                        //    else
                        //    {



                        //        Console.WriteLine("Invaild aacount number");

                        //    }


                        //    }





                        break;


                    case 6:
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invaild account number ");
                        break;
                }

                if (exit == true)
                {
                    break;
                }
                Console.WriteLine("Thank you for using the Bank System, press any key");
                Console.ReadLine();
                Console.Clear();

            }
        }


    }
}