using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankomatNew
{
    public class bankomat
    {
        private string password;
        private static int counter = 0;
        private int suma = 0;
        public bankomat()
        {
            this.password = "12345";
        }

        public void ChekPassword(string password,ref bool flag)
        {
            
                if (this.password == password)
                {
                    flag = true;
                    Console.WriteLine("Password is correct");
                }
                else
                {
                    counter++;
                    if(counter<3)
                    Console.WriteLine("The password is wrong, try again");
                }   
        }
        public void CounterCount()
        {
            if (counter == 3)
            {
                Console.WriteLine("you have blocked your card");
                Console.WriteLine("unlocke it in your bank resistance");
            }
        }
        public void SetMoney(int money)
        { 
                   
           suma  += money;
        }
        public int  GetMoney()
        {
            return suma;
        }
        public int GetCash(int money)
        {
            return suma -= money;
        }
    }
}
