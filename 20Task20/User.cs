using System;
using System.Collections.Generic;
using System.Text;

namespace _20Task20
{
    internal class User
    {
        private string username;
        private string password;





        public User(string Username, string Password)
        {
            username = Username;
            password = Password;

        }

        public User()
        {
        }

        public string Info()
        {
            return $"username {username},password {password}";
        }

        public string getUsername()
        { return username; }
        public string UsernameData
        {
            get { return username; }
            set
            {
                {

                    if (username.Length > 6)
                    {
                        username = username.Substring(0, 6);
                    }
                    else
                    {
                        Console.WriteLine("Xanalar bos buraxila bilmez");
                    }
                }
            }
        }
        public string getPassword() { return password; }
        public string PasswordData
        {
            get { return password; }
            set
            {
                {
                    if (password.Length >= 1)
                    {

                    }


                }

            }

        }
    }
}