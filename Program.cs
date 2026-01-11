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
                        //create account operation
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
                        //Deposite operation
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

                        Console.Write("Enter account number: ");
                        string accNumber2 = Console.ReadLine();
                        Console.Write("Enter withdraw amount: ");

                        double withdrawAmount = double.Parse(Console.ReadLine());

                        bool accountFound2 = false;

                        for (int i = 0; i < 100; i++)
                        {
                            if (accNumber2 == accounts[i])
                            {
                                balances[i] -= withdrawAmount;

                                accountFound2 = true;
                                break;
                            }

                        }
                        if (accountFound2 == false)
                        {
                            Console.WriteLine("account not found");
                        }
                        else
                        {
                            Console.WriteLine("withdraw succeefuly");
                        }
                        break;

                        

                    case 4:
                        //check moey operation
                        Console.Write("Enter account number: ");
                        string accNumber3 = Console.ReadLine();

                        bool accountFound3 = false;
                        double currentBalance = 0;

                        for (int i = 0; i < 100; i++)
                        {
                            if (accNumber3 == accounts[i])
                            {
                                currentBalance = balances[i];
                                accountFound3 = true;
                               

                                break;
                            }

                        }

                        //output
                        if (accountFound3 == false)
                        {
                            Console.WriteLine("sorry account not found");
                        }

                        else
                        {
                           

                                Console.WriteLine("Your balance = " + currentBalance);
                           
                        }




                            break;
                    case 5:
                        //transfar monery operation
                        Console.WriteLine("Enter source account number: ");
                        String sourceAccNum= Console.ReadLine();
                        Console.WriteLine("Enter destination account number: ");
                        String destAccNum = Console.ReadLine();
                        Console.WriteLine("Enter transfer amount: ");
                        double transferAmount = double.Parse(Console.ReadLine());

                        bool sourceFound= false;
                        int sourceBalance = 0;
                        for(int i = 0; i < 100; i++)
                        {
                            if(sourceAccNum == accounts[i])
                            {
                                sourceBalance = i;
                                sourceFound = true;
                                break;

                            }
                        }
                        if(sourceFound == false)
                        {
                            Console.WriteLine("source account not found");
                        }
                        else
                        {
                            bool destinationFound= false;
                            int destinationBalance = 0;
                            for(int i = 0;i < 100; i++)
                            {
                                if(destAccNum== accounts[i])
                                {
                                    destinationBalance = i;
                                    destinationFound = true;
                                    break;
                                }
                            }
                            if (destinationFound == false)
                            {
                                Console.WriteLine("destination account not found");
                            }
                            else
                            {
                                if (balances[sourceBalance] >= transferAmount)
                                {
                                    balances[sourceBalance]-=transferAmount;
                                   balances [destinationBalance ]+= transferAmount;
                                }
                                else
                                {
                                    Console.WriteLine("Insufficient balance in soruce account");
                                }
                            }
                        }



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