using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Security.Cryptography;

namespace PasswordEncryption
{
    public class AuthenSystem
    {
        Dictionary<string, string> UserDict = new Dictionary<string, string>();

        public void HeaderDisplay()
        {
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("\n                 PASSWORD AUTHENTICATION SYSTEM");
            Console.WriteLine("\n--------------------------------------------------------------------");
        }

        public void InitialDisplay()
        {
            int screenSelection;            

            Console.WriteLine("\nPlease select one option from the following list:");
            Console.WriteLine("1. Create An Account");
            Console.WriteLine("2. Authenticate A User");
            Console.WriteLine("3. Exit Application");
            Console.WriteLine("\nEnter your selection: ");

            while (!int.TryParse(Console.ReadLine(), out screenSelection))
             {
                 Console.WriteLine("Enter a valid selection: ");
             }
            
            switch(screenSelection)
            {
                case 1:
                    Console.Clear();
                    HeaderDisplay();
                    CreateAccount();
                    break;
                case 2:
                    Console.Clear();
                    HeaderDisplay();
                    AuthenticateUser();
                    break;
                case 3:
                    Console.Clear();
                    HeaderDisplay();
                    ExitApp();
                    break;
            }
        }

        public void CreateAccount()
        {   
            Console.WriteLine(">>>To return to the main menu, please enter 'return' at any time<<<\n");                      
            
            Console.WriteLine("***A username must contain atleast 8 characters***");
            Console.WriteLine("Please create a username: ");
            string username = Console.ReadLine();
            while (username.Length < 8 || UserDict.ContainsKey(username) || username.ToLower() == "return")
            { 
                if (username.ToLower() == "return")
                {
                    BackToHome();                    
                    break;
                }
                if (username.Length < 8)
                {
                    Console.WriteLine("That is not a valid username. Please try again:");
                }
                if (UserDict.ContainsKey(username))
                {
                    Console.WriteLine("That username already exists. Please try again:");
                }
                username = Console.ReadLine();
            }

            Console.WriteLine("\n***A password must contain atleast 10 characters***");
            Console.WriteLine("Please create a password: ");
            string plainpassword = Console.ReadLine();
            while (plainpassword.Length < 10 || plainpassword.ToLower() == "return")
            {
                if (plainpassword.ToLower() == "return")
                {
                    BackToHome();
                    break;
                }
                if (plainpassword.Length < 10)
                {
                    Console.WriteLine("That is not a valid password. Please try again:");
                    plainpassword = Console.ReadLine();
                }
            }

            Console.WriteLine("Please confirm your password:");
            string confirmpassword = Console.ReadLine();
            while (confirmpassword != plainpassword || confirmpassword.ToLower() == "return")
            {
                if (confirmpassword.ToLower() == "return")
                {
                    BackToHome();
                    break;
                }
                if (confirmpassword != plainpassword)
                {
                    Console.WriteLine("Passwords do not match. Please try again: ");
                    confirmpassword = Console.ReadLine();
                }
            }

            string hashedpassword = HashPassword(plainpassword);
            UserDict.Add(username, hashedpassword);

            Console.Clear();
            HeaderDisplay();
            Console.WriteLine("Success!");
            Console.WriteLine($"Your username is: {username}\nYour plain password is: {plainpassword}\nYour encrypted password is: {hashedpassword}");
            Console.WriteLine("\n1. Return To Main Menu");
            Console.WriteLine("2. Create Another Account");
            Console.WriteLine("Please enter your selection: ");
            int selection;
            
            while (!int.TryParse(Console.ReadLine(), out selection))
            {
                Console.WriteLine("Enter a valid selection: ");
            }
            switch(selection)
            {
                case 1:
                    BackToHome();
                    break;
                case 2:
                    Console.Clear();
                    HeaderDisplay();
                    CreateAccount();
                    break;
            }
        }
        
        public string HashPassword(string aplainpassword)
        {
            //Credit for understanding SHA256 to Microsoft Docs and c-sharpcorner
            using SHA256 sha256Hash = SHA256.Create();
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(aplainpassword));
            StringBuilder stringbuilder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                stringbuilder.Append(bytes[i].ToString("x2"));
            }
            string hashedpassword = stringbuilder.ToString();
            return hashedpassword;
        }

        public void BackToHome()
        {
            Console.Clear();
            HeaderDisplay();
            InitialDisplay();
        }

        public void AuthenticateUser()
        {
            Console.WriteLine("Username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Password: ");
            string password = Console.ReadLine();
            string hashedpassword = HashPassword(password);

            if(!UserDict.ContainsKey(username))
            {
                Console.Clear();
                HeaderDisplay();
                Console.WriteLine($"Account with username '{username}' does not exist.\n\nReturning To Main Menu...");
                Thread.Sleep(1000);
                BackToHome();

            }
            if(UserDict.TryGetValue(username, out string actualpassword))
            {
                if (actualpassword == hashedpassword)
                {
                    Console.Clear();
                    HeaderDisplay();
                    Console.WriteLine("\nSuccessfully Authenticated!\n\nReturning To Main Menu...");
                    Thread.Sleep(1000);
                    BackToHome();
                }
                else
                {
                    Console.Clear();
                    HeaderDisplay();
                    Console.WriteLine("\nInvalid Password!\n\nReturning To Main Menu...");
                    Thread.Sleep(1000);
                    BackToHome();
                }
            }            
        }

        public void ExitApp()
        {
            foreach(KeyValuePair<string, string> pair in UserDict)
            {
                Console.WriteLine(pair);
            }

            Console.WriteLine("Thank you for stopping by.");
            Thread.Sleep(1000);
            Environment.Exit(0);
        }
    }
}
