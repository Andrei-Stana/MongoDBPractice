using System;

namespace MongoDBPractice
{
    class Program
    {


        static void Main(string[] args)
        {
            //Takes your given data and saves it into the Db

            Console.WriteLine("Was ist dein Vornamen?");
            string firstname = Console.ReadLine();
            Console.WriteLine("Was ist dein Nachnamen?");
            string lastname = Console.ReadLine();
            Console.WriteLine("Wie alt bist du?");
            string age = Console.ReadLine();
            int intAge = Int16.Parse(age);
            Console.WriteLine();

            //Generates your own code to identify (Not done yet)
            
            for (int i = 0; i < 5; i++)
            {
                Random randInt = new Random();
                int randomNumber = randInt.Next(1, 10);
            }

            //Creates a Db and it inserts a record

            CRUD db = new CRUD("Personenbuch");
            db.insertRecord("Nutzer", new Personenbeschreibung { firstName = firstname, lastName = lastname, Age = intAge, Code = 1412 });
        }

    }
}
