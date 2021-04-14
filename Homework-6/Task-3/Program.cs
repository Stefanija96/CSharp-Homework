using System;
using Task_3.MyClasses;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Customer one = new Customer("Jane", "Doe", 654321, 4321, 1000);
            Customer two = new Customer("Bob", "Bobsky", 123456, 1234, 1000);
            Customer three = new Customer("John", "Doe", 123465, 2345, 1000);
            Customer[] customers = new Customer[]
            {  one, two, three
            };
            Menu(customers);


            void Menu(Customer[] customers)
            {
                bool isSuccessful = false;
                while (!isSuccessful)
                {

                    Console.WriteLine("Welcome to the ATM");
                    Console.WriteLine("Do you want to 1.LOGIN or 2.REGISTER");
                    bool checkAnswer = int.TryParse(Console.ReadLine(), out int userAnswer);

                    if (!checkAnswer)
                    {
                        Console.WriteLine("Please enter 1 or 2.");
                        continue;
                    }
                    switch (userAnswer)
                    {
                        case 1:
                            {
  
                                customer.Login(customers);
                                SubMenu(customers);
                                AdditionalAction();
                                isSuccessful = !isSuccessful;
                             
                                break;
                            }

                        case 2:
                            {
                                customer.Register(customers);
                                SubMenu(customers);
                                AdditionalAction();
                                isSuccessful = !isSuccessful;
                               
                                break;
                            }

                    }
                }
            }
            void AdditionalAction()
            {
                bool doAgain = false;
                while (!doAgain)
                {
                    Console.WriteLine("Do you want to another transaction?If yes click  y, if no click n");
                    string actionTaker = Console.ReadLine();
                    if (actionTaker.ToLower() == "y")
                    {
                        SubMenu(customers);
                    }
                    else if (actionTaker.ToLower() == "n")
                    {
                        Console.WriteLine("Thank you for using our ATM");
                        doAgain = !doAgain;
                    }
                }
               
            }
            void SubMenu(Customer[] customers)
            {
            

                Console.WriteLine("What would you like to do?");
                Console.WriteLine("\n1.Balance Checking \n2.Cash Withdrawal \n3.Cash Deposit");

                string userInput = Console.ReadLine();

                if (userInput == "1")
                {

                    foreach (var customer in customers)
                    {
                        Console.WriteLine($"Your balance is {customer.CheckBalance()}$$");
                        return;
                    }
                   
                        
                     
                }
                if (userInput == "2")
                {
                    Console.WriteLine("Please enter the amount of money you want to withdrawal:");
                    int cashWithdrawal = int.Parse(Console.ReadLine());
                    foreach (var customer in customers)
                    {
                        CashWitdrawal(cashWithdrawal, customer.CheckBalance());
                        return;
                    }
                }
                if (userInput == "3")
                {
                    Console.WriteLine("Enter the amount of cash you want to deposit:");
                    int cashDeposit = int.Parse(Console.ReadLine());
                    foreach (var customer in customers)
                    {
                        CashDeposit(cashDeposit, customer.CheckBalance());
                        return;
                    }
                }
   
            }
            static void CashDeposit(int cash, double balance)
            {
                Console.WriteLine($"You've deposit {cash}$. Your balance now is {balance + cash}$");

            }
            static void CashWitdrawal(int cash, double balance)
            {

                if (cash > balance)
                {
                    Console.WriteLine($"You don't have that much money on the account.The biggest amount you can withdrawal is: {balance}$");
                }
                else
                {
                    balance -= cash;
                    Console.WriteLine($"You withdrew {cash}$. You have {balance}$ left on your account.");
                }
               


            }
        }
    }
}





