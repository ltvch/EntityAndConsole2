using System;
using System.Linq;

namespace EntityAndConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (entityandconsoleContext db = new entityandconsoleContext())
            {
                var users = db.Users.ToList();
                Console.WriteLine("List of objects");
                foreach (Users u in users)
                {
                    Console.WriteLine($"{u.Id}.{u.Name}-{u.Age}");
                }
            }
            Console.ReadKey();
        }
    }
}
