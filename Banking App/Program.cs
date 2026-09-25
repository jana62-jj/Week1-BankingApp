// Calls the method so the banking app starts
BuildBankingApp();

// This method contains the whole banking app
void BuildBankingApp()
{
    // Stores the main menu choice typed by the user
    int choice = 0;

    // Stores the starting bank balance
    double accountBalance = 1000.00;

    // Stores the amount of money the user wants to deposit
    double depositAmount;

    // Displays the main menu heading
    Console.WriteLine("Please choose an option");
    Console.WriteLine("=======================");

    // Displays option 1
    Console.WriteLine("1 - Deposit money");

    // Displays option 2
    Console.WriteLine("2 - View current account information");

    // Asks the user to select option 1 or 2
    Console.WriteLine("Please choose option 1 or 2");

    // Reads the number the user types and converts it into an integer
    choice = Convert.ToInt32(Console.ReadLine());

    // Checks whether the user chose a valid option: 1 or 2
    if (choice == 1 || choice == 2)
    {
        // Checks whether the user chose option 1: deposit money
        if (choice == 1)
        {
            // Asks how much money they want to deposit
            Console.WriteLine("How much would you like to deposit?");

            // Tells them to use a decimal point, for example 10.50
            Console.WriteLine("Enter amount using a decimal point");

            // Reads the deposit amount and converts it to a decimal number
            depositAmount = Convert.ToDouble(Console.ReadLine());

            // Adds the deposit amount to the account balance
            accountBalance += depositAmount;

            // Displays the updated account balance
            Console.WriteLine($"Your new balance is {accountBalance}");
        }
        else
        {
            // Runs when the user chooses option 2
            Console.WriteLine("You have chosen to view current account information");

            // Displays the current account balance
            Console.WriteLine($"Your current account balance is {accountBalance}");
        }
    }
    else
    {
        // Runs when the user enters a number other than 1 or 2
        Console.WriteLine("Invalid choice, please choose 1 or 2");
    }

    // Keeps the console window open until the user presses a key
    Console.ReadKey();
}