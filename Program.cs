namespace BankSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] owners = new string[100];
            string[] accounts = new string[100];
            double[] balances = new double[100];
            int LastAccountIndex = -1;
            String storedAccountNumber = "saving 3456";
            double storedBalance = 500;
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
                        //Deposit Money

                        break;



                    case 3:
                        //Withdraw Money
                        Console.WriteLine("Enter amount to withdraw:");
                        balances[0] = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter your account number:");
                        accounts[0]= Console.ReadLine();

                        if (accounts[0] == storedAccountNumber)
                        {
                            if (balances[0] <= storedBalance)
                            {
                                storedBalance -= balances[0];
                                Console.WriteLine("Please collect your cash:");
                                Console.WriteLine("Remaining balance:" + storedBalance);
                            }
                            else
                            {
                                Console.WriteLine("Insufficient balance");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invaild account number");
                        }


                



                break;
                    case 4:
                        break;
                    case 5:
                        break;

                    case 6:
                        break;

                    default:
                        Console.WriteLine("Invaild account number ");
                        break;
                }
                Console.WriteLine("Thank you for using the Bank System, press any key");
                Console.ReadLine();
                Console.Clear();

            }
        }
        }
    }
