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
                        //Console.WriteLine("set Salary to:" + salary+ " OMR");

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

            //================================================================================


            //Task 2 - ATM servisec


            int atmOption = -1;
            while (atmOption != 0)
            {
                Console.WriteLine(" === ATM Services ===");
                Console.WriteLine("1) Bank Info");
                Console.WriteLine("2) Branch Info");
                Console.WriteLine("3)  Opening Hours");
                Console.WriteLine("0)  Back to Main Menu");
                Console.Write("\nSelect: ");
                atmOption = Convert.ToInt32(Console.ReadLine());

                switch (atmOption)
                {
                    //bank info
                    case 1:
                        Console.WriteLine("\n--- Banck information ---");
                        Console.WriteLine("National Bank of Oman");
                        Console.WriteLine("Tagline: Trusted Banking for a Better Future");
                        Console.WriteLine("Founded: 1973");
                        break;

                    //branch info
                    case 2:
                        Console.WriteLine("\n--- branch information ---");
                        Console.WriteLine("Branch Name: Ruwi Main Branch");
                        Console.WriteLine("City: Muscat");
                        Console.WriteLine("Address: Sultan Qaboos Street, Ruwi, Muscat, Oman");
                        break;

                    //opening hours
                    case 3:
                        Console.WriteLine("\n--- opining hours ---");
                        Console.WriteLine("Weekdays: 8:00 AM - 2:00 PM");
                        Console.WriteLine("Weekend: Closed");
                        break;

                    //back to main menu
                    case 0:
                        Console.WriteLine("Returning to Main Menu...");
                        break;

                    //default case
                    default:
                        Console.WriteLine("Invalid selection. Please try again.");
                        break;
                }
            }

            //=================================================================================



            // Task 3 - Viewer Data
            Console.WriteLine(" === VIEW ACCOUNT DATA ===");
            Console.WriteLine("1) Account Number -> ");
            Console.WriteLine("2) Holder Name -> ");
            Console.WriteLine("3) Balance -> ");
            Console.WriteLine("4) Account Status -> ");
            Console.WriteLine("5) Account Type -> ");
            Console.WriteLine("0) Back");
            

            int view = -1;
            while (view != 0)
            { 
                Console.Write("\nSelect: ");
                view = Convert.ToInt32(Console.ReadLine());
               

                switch (view)
                {

                    // case 1 display account num
                    case 1:
                        Console.WriteLine("Account Number: " + accountNumber);
                        break;

                    // case 2 display holder name
                    case 2:
                        Console.WriteLine("Holder Name: " + holderName);
                        break;

                    // case 3 display balance
                    case 3:
                        Console.WriteLine("Balance: " + balance);
                        break;

                    // case 4 display account status
                    case 4:
                        Console.WriteLine("Account Status: " + isActive);
                        break;

                    // case 5 display account type 
                    case 5:
                        Console.WriteLine("Account Type: " + accountType);
                        break;

                    // case 0 back..
                    case 0:
                        Console.WriteLine(" Back ");
                        break;

                    default:
                        Console.WriteLine(" Field not Available!");
                        break;
                }
            }

            //=================================================================================


            // Task 4 - ATM validation
            Console.WriteLine(" === AUTHENTICATION ===");
            Console.WriteLine("1) Enter PIN ");
            Console.WriteLine("2) Forgot PIN ");
            Console.WriteLine("0) Back");

            const int CORRECT_PIN = 4821;
            const int MAX_ATTEMPTS = 3;
            int auth = -1;

            while (auth != 0)
            {
                Console.Write("\nSelect: ");
                auth = Convert.ToInt32(Console.ReadLine());

                switch (auth)
                {
                    // Enter PIN

                    // invalid format -> size not 4
                    // Access granted -> number is correct
                    // incorect pin

                    case 1:
                        int attempts = 0;
                        bool accessGranted = false;

                        while (attempts < MAX_ATTEMPTS && !accessGranted)
                        {
                            Console.Write("Enter PIN: ");
                            string pinInput = "";
                            ConsoleKeyInfo key;

                            // Hidden PIN input
                            do
                            {
                                key = Console.ReadKey(true); // read from keyboard

                                if (key.Key == ConsoleKey.Delete || key.Key == ConsoleKey.Spacebar)  // if the key not enter
                                {

                                }

                                if (key.Key != ConsoleKey.Enter)  // if the key not enter
                                {
                                    pinInput += key.KeyChar;
                                    Console.Write("*"); // show *
                                }

                            } while (key.Key != ConsoleKey.Enter); // continue repeat if the the user not click to enter. it will stop here

                            Console.WriteLine();
                            // here is problem, becaues also when i press in delete key so =  i will ask mr.karim!!


                            /* while (true)
        {
            keyInfo = Console.ReadKey(intercept: true); // Do not show key

            // If Enter is pressed, stop reading
            if (keyInfo.Key == ConsoleKey.Enter)
            {
                Console.WriteLine(); // Move to next line
                break;
            }
            // Handle Backspace
            else if (keyInfo.Key == ConsoleKey.Backspace)
            {
                if (password.Length > 0)
                {
                    password.Remove(password.Length - 1, 1);
                    Console.Write("\b \b"); // Remove last '*'
                }
            }       */



                            if (pinInput.Length != 4)  // check the size of pin 
                            {
                                Console.WriteLine("Invalid PIN format.");
                            }
                            else if (Convert.ToInt32(pinInput) == CORRECT_PIN) // the num input is it = to "4821"
                            {
                                Console.WriteLine($"Access granted. Welcome, {holderName}");
                                accessGranted = true;  // the enterd success, i use it because i have loop
                            }
                            else
                            {
                                Console.WriteLine("Incorrect PIN."); // the size correct but the number is false
                                attempts++;  // every time increse 1
                            }
                        }
                        break;

                    // Forgot PIN
                    case 2:
                        Console.WriteLine("Please visit the nearest branch with your National ID.");
                        break;

                    // Back..
                    case 0:
                        Console.WriteLine("Returning...");
                        break;

                    // Invalid option..
                    default:
                        Console.WriteLine("Invalid selection.");
                        break;
                }
            }



            //=================================================================================


            // Task 5 -  prints receipt data = only display the info will get from task 1
            Console.WriteLine(" === Print Receipt === ");
            Console.WriteLine("1) Short Receipt");
            Console.WriteLine("2) Detailed Receipt");
            Console.WriteLine("3) Balance Only");
            Console.WriteLine("0) Back");

            int recepit = -1;
            while (recepit != 0) {
                Console.WriteLine("\nSelect format: ");
                recepit = Convert.ToInt32(Console.ReadLine());

                switch (recepit)
                {

                    // short recepit
                    case 1:
                        //  string accstr = accountNumber.ToString(); // convert the account num to string because the substring only works in string
                        string maskaccount = "****" + (accountNumber % 10000);

                        Console.WriteLine(" === Short Receipt ===");
                        Console.WriteLine("Account   : " + maskaccount);
                        Console.WriteLine("Holder    : " + holderName);
                        Console.WriteLine("Balance   : " + balance.ToString("F3") + " OMR");
                        break;

                    // Detailed Receipt
                    case 2:
                        Console.WriteLine(" === DETAILED RECEIPT === ");
                        Console.WriteLine("Account Number: " + accountNumber);
                        Console.WriteLine("Holder Name: " + holderName);
                        Console.WriteLine("Balance: " + balance.ToString("F3") + "OMR");
                        Console.WriteLine("Account Status: " + isActive);
                        Console.WriteLine("Account Type: " + accountType);
                        Console.WriteLine("Age: " + age);
                        Console.WriteLine("Credit score: " + creditScore);
                        break;


                    // balance only
                    case 3:
                        Console.WriteLine(" === Balance Only === ");
                        Console.WriteLine("Balance " + balance.ToString("F3") + "OMR");
                        break;



                    // Back..
                    case 0:
                        Console.WriteLine("Returning to ATM Services...");
                        break;


                    // defult
                    default:
                        Console.WriteLine("Invalid receipt format.");
                        break;
                }
            }




            //=================================================================================


            // Task 6 - Transaction Calculator


            // balance after deposit






























        }
    }
    }
    

