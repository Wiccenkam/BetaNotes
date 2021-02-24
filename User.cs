using System;
using System.Collections.Generic;
using System.Text;

namespace Kursach2
{
    public static class User
    {
        public static string login { get; set; }
        public static string Name { get; set; }
        public static string Surname { get; set; }

        
        public static void loginUser(string ad)
        {
            login = ad;
        }
        public static void NameUser(string name)
        {
            Name = name;
            
        }
        public static void SurnameUser( string surname)
        {
            
            Surname = surname;
        }
    }
}
