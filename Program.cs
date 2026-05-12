namespace BankingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            int accountNumber = 0;
            string holderName = "";
            double balance = 0;
            bool isActive = false;
            char accountType = ' ';
            bool isEmployed = false;
            double salary = 0;
            int creditScore = 0;
            int age = 0;
            double deposit = 0;
            double withdrawal = 0;
            double annualRate = 0;
            double avgBalance = 0;
            bool setupCompleted = false;

            // Task 1 - system setup
           
                
                Console.WriteLine(" National Bank Of Oman - System Setup ");
                Console.WriteLine("\n--- Account & Customer Data ---\n");

                Console.WriteLine("1) Enter Account Number");
                Console.WriteLine("2) Enter Holder Name");
                Console.WriteLine("3) Enter current Balance");
                Console.WriteLine("4) Set Account status");
                Console.WriteLine("5) Enter Account Type");
                Console.WriteLine("\n--- Customer Profile ---\n");
                Console.WriteLine("6) Set Employment status");
                Console.WriteLine("7) Enter Monthly Salary");
                Console.WriteLine("8) Enter credit store");
                Console.WriteLine("9) Enter customer age");
                Console.WriteLine("\n--- Transaction Data ---\n");
                Console.WriteLine("10) Enter last deposit");
                Console.WriteLine("11) Enter last withdrawal");
                Console.WriteLine("12) Enter annual interest rate");
                Console.WriteLine("13) Enter average monthly balance");
                Console.WriteLine("0)  Setup complete — launch Main Menu");

                Console.Write("\nSelect option: ");


            int option = -1;

            while (option != 0)
            {
                Console.Write("\nEnter option (1-13, 0 to finish): ");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Write("Enter account number: ");
                        accountNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"set Account number to: {accountNumber}");
                        break;

                    case 2:
                        Console.Write("Enter Holder Name: ");
                        holderName = Console.ReadLine();
                        Console.WriteLine($"set Holder Name to: {holderName}");
                        break;

                    case 3:
                        Console.Write("Enter Balance: ");
                        balance = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"set Balance to: {balance:F3} OMR");
                        break;

                    case 4:
                        Console.Write("Enter 1=Active / 0=Inactive: ");
                        isActive = Convert.ToInt32(Console.ReadLine()) == 1;
                        Console.WriteLine($"set Active to: {isActive}");
                        break;

                    case 5:
                        Console.Write("Enter Account Type (S/C/F): ");
                        accountType = Convert.ToChar(Console.ReadLine().ToUpper());
                        Console.WriteLine($"set Type to: {accountType}");
                        break;

                    case 6:
                        Console.Write("Enter 1=Employed / 0=Not: ");
                        isEmployed = Convert.ToInt32(Console.ReadLine()) == 1;
                        Console.WriteLine($"set Employed to: {isEmployed}");
                        break;

                    case 7:
                        Console.Write("Enter Salary: ");
                        salary = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"set Salary to: {salary:F3} OMR");
                        break;

                    case 8:
                        Console.Write("Enter Credit Score: ");
                        creditScore = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"set Credit Score to: {creditScore}");
                        break;

                    case 9:
                        Console.Write("Enter Age: ");
                        age = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"set Age to: {age}");
                        break;

                    case 10:
                        Console.Write("Enter Deposit: ");
                        deposit = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"set Deposit to: {deposit:F3} OMR");
                        break;

                    case 11:
                        Console.Write("Enter Withdrawal: ");
                        withdrawal = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"set Withdrawal to: {withdrawal:F3} OMR");
                        break;

                    case 12:
                        Console.Write("Enter Interest Rate: ");
                        annualRate = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"set Rate to: {annualRate:F3}%");
                        break;

                    case 13:
                        Console.Write("Enter Avg Balance: ");
                        avgBalance = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"set Avg Balance to: {avgBalance:F3} OMR");
                        break;

                    case 0:
                        Console.WriteLine("Setup completed. Launching Main Menu...");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }



        }
        }
    }

