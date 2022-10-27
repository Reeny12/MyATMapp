using System;
using System.Collections.Generic;
using System.Linq;

namespace MyATMapp
{
    class Program
    {
        static void Main(string[] args)
        {
            // cardHolder currentUser = new cardHolder("Maureen","Lebotsa","23456",1234,563);
            // Console.WriteLine(currentUser.FirstName);
            void printOptions()
            {
                Console.WriteLine("Please choose from one of the following options...");
                Console.WriteLine("1. Deposit ");
                Console.WriteLine("2. Withdraw ");
                Console.WriteLine("3. Show balance ");
                Console.WriteLine("4. Exit ");
            }
            void deposit(cardHolder currentUser)
            {
                Console.WriteLine("How much money would you like to DEPOSIT?");
                double deposit = Double.Parse(Console.ReadLine());
                currentUser.Balance = deposit + currentUser.Balance;
                Console.WriteLine("Thank you for your deposit, your current balance is " + currentUser.Balance);
            }

            void withdrawal(cardHolder currentUser)
            {
                Console.WriteLine("How much money would you like to WITHDRAW?");
                double withdrawal = Double.Parse(Console.ReadLine());
                if (withdrawal > currentUser.Balance)
                {
                    Console.WriteLine("Sorry:( You have insufficient funds");
                }
                else
                {
                   currentUser.Balance = currentUser.Balance - withdrawal;

                   Console.WriteLine("Your current balance is " + currentUser.Balance);
                }
            }
            void balance(cardHolder currentUser)
            {
                Console.WriteLine("Your current balance is " + currentUser.Balance);
            }
            List<cardHolder> cardHolders = new List<cardHolder>();
            cardHolders.Add(new cardHolder( "Maureen", "Lebotsa", "23456", 1234, 500000.78));
            cardHolders.Add(new cardHolder( "Amandla", "Stenberg", "54673", 8460, 200000.78));
            cardHolders.Add(new cardHolder( "Sindi", "Dlathu", "86403", 7456, 100000.78));
            cardHolders.Add(new cardHolder( "Willow", "Smith", "17539", 2653, 300000.78));

            Console.WriteLine("Welcome to SIMPLE ATM");
            Console.WriteLine("Please insert your Debit Card: ");
            string debitCardNum = " ";
            cardHolder currentUser;

            while (true)
            {
                try
                {
                    debitCardNum = Console.ReadLine();
                    currentUser = cardHolders.FirstOrDefault(a => a.CardNum == debitCardNum);
                    if (currentUser != null)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Card not recognized.Please try again!!!");
                    }

                }
                catch
                {
                    Console.WriteLine("Card not recognized.Please try again!!!");
                }
            }

            Console.WriteLine("Please enter your pin: ");
            int userpin = 0;
            while (true)
            {
                try
                {
                    userpin = int.Parse(Console.ReadLine());
                    if (currentUser.Pin == userpin)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect pin,please try again!!!");
                    }

                }
                catch
                {
                    Console.WriteLine("Incorrect pin,please try again!!!");
                }
            }

            Console.WriteLine("Hello,Welcome " + currentUser.FirstName);
            int option = 0;
            do
            {
                printOptions();
                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch
                {

                }
                if (option == 1)
                {
                    deposit(currentUser);
                }
                else if (option == 2)
                {
                    withdrawal(currentUser);
                }
                else if (option == 3)
                {
                    balance(currentUser);
                }
                else if (option == 4)
                {
                    break;
                }
                else
                {
                    option = 0;
                }

            }
            while(option != 4);

        } 
    }
}
