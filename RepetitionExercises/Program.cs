using System;
using System.Collections.Generic;
using RepetitionExercises.HomeTheaterClasses;

namespace RepetitionExercises
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Contact> Contacts = new List<Contact>();

            Contact contact1 = new Contact("Anders", 1992, true);
            Contact contact2 = new Contact("Nikolai", 1994, false);
            Contact contact3 = new Contact("Nanna", 2003, true);
            Contact contact4 = new Contact("Joan", 1960, true);

            Contacts.Add(contact1);
            Contacts.Add(contact2);
            Contacts.Add(contact3);
            Contacts.Add(contact4);

            foreach (Contact contact in Contacts)
            {
                contact.printsummary();
            }

            contact1.Email = "Anders@gmail.com";

            foreach (Contact contact in Contacts)
            {
                contact.printsummary();
            }


            HomeTheaterTest.Run();


            KeepConsoleWindowOpen();
        }


        private static void KeepConsoleWindowOpen()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to close application");
            Console.ReadKey();
        }
    }
}
