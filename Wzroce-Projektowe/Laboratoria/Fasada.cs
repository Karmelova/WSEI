using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WzorzecFasada
{
    public interface IUserService
    {
        void CreateUser(string email);

        void DeleteUser(string email);

        void NumberOfUsers();
    }

    public static class EmailNotification
    {
        public static void SendEmail(string to, string subject)
        {
            Console.WriteLine($"{subject} {to}");
        }
    }

    public class UserRepository
    {
        private readonly List<string> users = new List<string>
        {
            "john.doe@gmail.com", "sylvester.stallone@gmail.com"
        };

        public bool IsEmailFree(string email)
        {
            return !users.Contains(email);
        }

        public void AddUser(string email)
        {
            users.Add(email);
        }

        public void DeleteUser(string email)
        {
            users.Remove(email);
        }

        public int CountUsers()
        {
            return users.Count;
        }
    }

    public static class Validators
    {
        public static bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase);
        }
    }

    public class UserService : IUserService
    {
        private readonly UserRepository userRepository = new UserRepository();

        public void CreateUser(string email)
        {
            if (!Validators.IsValidEmail(email))
            {
                throw new ArgumentException("Błędny email");
            }
            if (!userRepository.IsEmailFree(email))
            {
                throw new ArgumentException("Podany adres został już zarejestrowany w bazie");
            }

            userRepository.AddUser(email);
            EmailNotification.SendEmail(email, "Welcome to our service");
        }

        public void DeleteUser(string email)
        {
            if (userRepository.IsEmailFree(email))
            {
                throw new ArgumentException("Podany adres nie istnieje w bazie");
            }

            userRepository.DeleteUser(email);
            EmailNotification.SendEmail(email, "Goodbye");
        }

        public void NumberOfUsers()
        {
            Console.WriteLine($"Aktualna liczba adresów: {userRepository.CountUsers()}");
        }
    }

    public class Program
    {
        private static void Main(string[] args)
        {
            IUserService userService = new UserService();

            userService.NumberOfUsers();
            userService.CreateUser("someemail@gmail.com");
            userService.NumberOfUsers();
            userService.DeleteUser("john.doe@gmail.com");
            userService.NumberOfUsers();
        }
    }
}
