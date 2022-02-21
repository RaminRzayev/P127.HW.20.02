using System;
using System.Collections.Generic;
using System.Text;

namespace P127.HW._20._02
{
    class User
    {
        private string UserName { get {

                return UserName;

            } 
            set {
                if (value.Length>6)
                {
                    UserName = value;
                }
                else
                {
                    Console.WriteLine("zehmet olmasa duzgun daxil edin.");
                }

            }
        }
        private string Password { 
            get {
                return Password;
            }
            set {
                if (value.Length<=1)
                {
                    Password = value;
                }
                else
                {
                    Console.WriteLine("duzgun parol daxil edin.");
                }

            }
        }

        public User(string username, string password)
        {
            UserName = username;
            Password = password;
        }

        public void GetInfoUser()
        {
            Console.WriteLine($"UserName: {UserName}\n Password: {Password}\n");
        }
    }
}
