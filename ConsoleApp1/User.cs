using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class User
    {
        public User( string userName)
        {
            this.UserName = userName;
        }

        private string _userName;
        private string _password;


        public string UserName
        {
            get { return _userName; }
            set {

                if (value.Length<=25 && value.Length >= 6)
                {
                    _userName = value;
                }
                else
                {
                    Console.WriteLine("\nIstifaadeci adinda simvol sayi 6 dan az 25 den cox ola bilmez!!!");
                }


             }
        }
        public string Password
        {
            get { return _password; }
            set
            {

                if (value.Length >= 8 && value.Length <= 25 && HasDigit(value) && HasUpper(value) && HasLower(value))
                {
                    _password = value;

                }

                else
                {
                        Console.WriteLine("\nParolda simvol sayi 8-den az 25-den cox ola bilmez , en axzi 1 reqem ,1 boyuk herf ,1 kicik herf olamlidir!!!");
                
                }


            }
        }
        public bool HasDigit( string password)
        {
            foreach (var item in password)
            {
                if (char.IsDigit(item))
                {
                    return true;
                }
               
            }
           return false;
        }

        public bool HasUpper(string password)
        {
            foreach (var item in password)
            {
                if (char.IsUpper(item))
                {
                    return true;
                }

            }
            return false;
        }
        public bool HasLower(string password)
        {
            foreach (var item in password)
            {
                if (char.IsLower(item))
                {
                    return true;
                }

            }
            return false;
        }
        public void GetInfo()
        {
            Console.WriteLine("\n\n=========================== ISTIFADECI ================================== \n");
            Console.WriteLine($"          Istifadeci adi :{UserName}          Parol :{Password}");
            Console.WriteLine("\n--------------------------------------------------------------------------\n");
        }
    }
}
