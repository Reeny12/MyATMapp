using System;
using System.Collections.Generic;
using System.Text;

namespace MyATMapp
{
    class cardHolder
    {
        string firstName;
        string lastName;
        string cardNum;
        int pin;
        double balance;

        public cardHolder(string firstName, String lastName, string cardNum, int pin, double balance)
        {
            this.firstName = firstName;
            this.lastName = lastName; ;
            this.cardNum = cardNum;
            this.pin = pin;
            this.balance = balance;
        }

        public string FirstName
        {   
            get { return firstName;}
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName;}
            set { lastName = value; }
        }

        public string CardNum
        {
            get { return cardNum;}
            set { cardNum = value;}
        }

        public int Pin
        {
            get { return pin;}
            set { pin = value;}
        }

        public double Balance
        {
            get { return balance;}
            set { balance = value;}
        }

       
    }
}
