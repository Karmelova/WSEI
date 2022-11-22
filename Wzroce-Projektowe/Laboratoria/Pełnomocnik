using System;
using System.Collections.Generic;

namespace Pelnomocnik
{

    public class User
    {

        private bool HasAdminPrivilages;

        public User(bool privilages) 
        {
            HasAdminPrivilages = privilages;
        }

        public void MakeAdmin()
        {
            this.HasAdminPrivilages = true;
        }

        public bool IsAdmin()
        {
            return HasAdminPrivilages;
        }

    }

    public interface Information
    {
        public abstract void DisplayData();
        public abstract void DisplayRestrictedData();
    }

    public class Database : Information
    {

        private Dictionary<string, double> Map;

        public Database()
        {
            Map = new Dictionary<string, double>();
            Map.Add("Zyzio MacKwacz", 2500d);
            Map.Add("Scooby Doo", 11.4d);
            Map.Add("Adam Mackiewicz", 15607.95d);
            Map.Add("Rick Morty", 429.18d);
        }

        public void DisplayData()
        {
            Console.WriteLine("Użytkownicy:");
            foreach (var names in Map.Keys) 
            {
                Console.WriteLine(names);
            }
        }

        public void DisplayRestrictedData()
        {

            foreach (var items in Map)
            {
                Console.WriteLine(items.Key + " zarabia " + items.Value + " zł miesięcznie");
            }
        }
    }

    public class DatabaseGuard : Information
    {

        private Database DB;
        private User user;

        public DatabaseGuard(User u)
        {
            DB = new Database();
            user = u;
        }

        public void DisplayData()
        {
            DB.DisplayData();
        }

        public void DisplayRestrictedData()
        {
            if (user.IsAdmin())
            {
                DB.DisplayRestrictedData();
            }
            else {
                Console.WriteLine("Nie masz wystarczających uprawnień");
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            var Zbyszek = new User(false);
            var db = new DatabaseGuard(Zbyszek);

            db.DisplayData();

            Console.WriteLine("---------------------------------------------------------");

            db.DisplayRestrictedData();

            Console.WriteLine("---------------------------------------------------------");
using System;
using System.Collections.Generic;

namespace Pelnomocnik
{

    public class User
    {

        private bool HasAdminPrivilages;

        public User(bool privilages) 
        {
            HasAdminPrivilages = privilages;
        }

        public void MakeAdmin()
        {
            this.HasAdminPrivilages = true;
        }

        public bool IsAdmin()
        {
            return HasAdminPrivilages;
        }

    }

    public interface Information
    {
        public abstract void DisplayData();
        public abstract void DisplayRestrictedData();
    }

    public class Database : Information
    {

        private Dictionary<string, double> Map;

        public Database()
        {
            Map = new Dictionary<string, double>();
            Map.Add("Zyzio MacKwacz", 2500d);
            Map.Add("Scooby Doo", 11.4d);
            Map.Add("Adam Mackiewicz", 15607.95d);
            Map.Add("Rick Morty", 429.18d);
        }

        public void DisplayData()
        {
            Console.WriteLine("Użytkownicy:");
            foreach (var names in Map.Keys) 
            {
                Console.WriteLine(names);
            }
        }

        public void DisplayRestrictedData()
        {

            foreach (var items in Map)
            {
                Console.WriteLine(items.Key + " zarabia " + items.Value + " zł miesięcznie");
            }
        }
    }

    public class DatabaseGuard : Information
    {

        private Database DB;
        private User user;

        public DatabaseGuard(User u)
        {
            DB = new Database();
            user = u;
        }

        public void DisplayData()
        {
            DB.DisplayData();
        }

        public void DisplayRestrictedData()
        {
            if (user.IsAdmin())
            {
                DB.DisplayRestrictedData();
            }
            else {
                Console.WriteLine("Nie masz wystarczających uprawnień");
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            var Zbyszek = new User(false);
            var db = new DatabaseGuard(Zbyszek);

            db.DisplayData();

            Console.WriteLine("---------------------------------------------------------");

            db.DisplayRestrictedData();

            Console.WriteLine("---------------------------------------------------------");

            Zbyszek.MakeAdmin();
            db.DisplayRestrictedData();

        }
    }

}
            Zbyszek.MakeAdmin();
            db.DisplayRestrictedData();

        }
    }

}
