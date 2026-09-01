using System;
using System.Collections.Generic;
using HelloConsoleApp.Models;
using HelloConsoleApp.Services;

namespace HelloConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Hello World!");

            while (Menu())
            {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            } 
        }

         static void CreatePerson()
        {
            Console.WriteLine("Enter your name:");
            String name = Console.ReadLine();

            Console.WriteLine("Enter your date of birth (YYYY/MM/DD)");
            String birthday = Console.ReadLine();

            Person newPerson = new Person()
            {
                Name = name,
                Birthday = DateTime.Parse(birthday)
            };

            PersonService personService = new PersonService();
            personService.AddPerson(newPerson);

        }

        static void DeletePerson()
        {
            Console.WriteLine("Enter the ID of the person you want to delete:");
            int id = int.Parse(Console.ReadLine());

            PersonService personService = new PersonService();
            personService.DeletePerson(id);
        }

        static void UpdatePerson()
        {
            Console.WriteLine("Enter the ID of the person you want to update:");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the new name:");
            String name = Console.ReadLine();

            Console.WriteLine("Enter the new date of birth (YYYY/MM/DD)");
            String birthday = Console.ReadLine();

            Person updatedPerson = new Person()
            {
                Name = name,
                Birthday = DateTime.Parse(birthday)
            };

            PersonService personService = new PersonService();
            personService.UpdatePerson(id, updatedPerson);
        }

        static void ListPersons()
        {
            PersonService personService = new PersonService();
            var personsList = personService.GetAllPersons();

            Console.WriteLine("List of Persons:");
            foreach (var person in personsList)
            {
                Console.WriteLine($"ID: {person.Id}, Name: {person.Name}, Birthday: {person.Birthday.ToShortDateString()}, Age: {person.Age}");
            }
        }
        
        static bool Menu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Person Management System");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Select an option:");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1 - Create Person");
            Console.WriteLine("2 - Update Person");
            Console.WriteLine("3 - Delete Person");
            Console.WriteLine("4 - List Persons");
            Console.WriteLine("5 - Exit");

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    CreatePerson();
                    return true;
                case 2:
                    UpdatePerson();
                    return true;
                case 3:
                    DeletePerson();
                    return true;
                case 4:
                    ListPersons();
                    return true;
                case 5:
                    Console.WriteLine("Exiting the program.");
                    return false;
                default:
                    Console.WriteLine("Invalid option.");
                    Console.ReadKey();
                    return true;
            }
        }
    }
}
