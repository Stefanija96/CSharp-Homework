using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3.MyClasses
{

}
public class Customer
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int CardNumber { get; set; }
    private double Balance { get; set; }
    private int Pin { get; set; }

    public Customer(string firstName, string lastName, int cardNumber, int pin, double balance)
    {
        FirstName = firstName;
        LastName = lastName;
        CardNumber = cardNumber;
        Pin = pin;
        Balance = balance;
    }
    public Customer()
    {

    }

    public double CheckBalance()
    {
     
        return Balance;
    }
    public int GetPin()
    {
        return Pin;

    }
    public string FullName()
    {
        return $"{FirstName} {LastName}";

    }
    public void Register(Customer[] customers)
    {
        bool isRegistered = false;

        while (!isRegistered)
        {
            Console.WriteLine("Please enter First Name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter a Last Name");
            string lastName = Console.ReadLine();

            Console.WriteLine("A system is generating a card number for you:");
            Random randomCard = new Random();
            int cardNumber = randomCard.Next(100000, 999999);
            Console.WriteLine($"Your card number is:{cardNumber}");

            Console.WriteLine("A system is generating a pin for you:");
            Random randomPin = new Random();
            int cardPin = randomPin.Next(1000, 9999);
            Console.WriteLine($"Your card pin is:{cardPin}");
            int balanceNew = 1000;
            

            foreach (var customer in customers)
            {
                if (customer.CardNumber == cardNumber)
                {
                    Console.WriteLine("This user already exists! ");
                    isRegistered = !isRegistered;
                    break;
                }

            }
            foreach (var customer in customers)
            {
                if (!isRegistered)
                {
                    Customer newCustomer = new Customer(firstName, lastName, cardNumber, cardPin, balanceNew)
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        CardNumber = cardNumber,
                        Pin = cardPin,
                        Balance = balanceNew
                    };
                    Array.Resize(ref customers, customers.Length + 1);
                    customers[customers.Length - 1] = newCustomer;
                    Console.WriteLine($"A new user has been registered. Welcome {newCustomer.FullName()}. Your balance is: {newCustomer.Balance}");
                    isRegistered = !isRegistered;
                }
            }

        }
    }
    public void Login(Customer[] customers)
    {
        Console.WriteLine("Welcome to the ATM");
        bool isLogged = false;

        while (!isLogged)
        {
            Console.WriteLine("Please enter your Card Number");
            string inputCardNumber = Console.ReadLine();
            if (string.IsNullOrEmpty(inputCardNumber))
            {
                Console.WriteLine("You need to enter a card number");
                continue;
            }
            bool isOkNum = int.TryParse(inputCardNumber.Replace("-", ""), out int cardNumber);

            if (!isOkNum || cardNumber.ToString().Length != 6)
            {
                Console.WriteLine("Invalid card number. Try again!");
                
                continue;
                
            }
            Console.WriteLine("Please enter your pin:");
            bool checkPin = int.TryParse(Console.ReadLine(), out int pin);
            if (!checkPin)
            {
                Console.WriteLine("Invalid pin number. Please enter pin!");
            };

            foreach (var customer in customers)
            {
                if (cardNumber == customer.CardNumber && pin == customer.GetPin())
                {
                    Console.WriteLine($"Welcome {customer.FullName()}");
                    isLogged = !isLogged;
                    return;
                }
            }
            Console.WriteLine("There was en error! ");
           
        }
    
    }
}


