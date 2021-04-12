//Author: Kimberly Retherford
//April 11th, 2021
//Password Encryption and Authentication

using System;

namespace PasswordEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            AuthenSystem ui = new AuthenSystem();
            ui.HeaderDisplay();
            ui.InitialDisplay();
        }
    }
}
