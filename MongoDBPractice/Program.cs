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
                Console.WriteLine("Dein Konto wird erstellt");

                //Generates your own code to identify 
            
                Random randInt = new Random();
                int randomNumber = randInt.Next(1000, 9999);
                Console.WriteLine("Dein eigener code ist " + randomNumber);
            

                //Creates a Db and it inserts a record

                CRUD db = new CRUD("Personenbuch");
                db.insertRecord("Nutzer", new Personenbeschreibung { firstName = firstname, lastName = lastname, Age = intAge, Code = randomNumber });
                Console.ReadKey();
            

        }

    }
}
