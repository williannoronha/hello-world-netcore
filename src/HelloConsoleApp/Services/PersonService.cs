using System;
using System.Collections.Generic;
using System.Text;
using HelloConsoleApp.Models;

namespace HelloConsoleApp.Services
{
    public class PersonService
    {
        private static List<Person> personsList = new List<Person>();
        public void AddPerson(Person person)
        {
            person.Id = personsList.Count > 0 ? personsList[personsList.Count - 1].Id + 1 : 1;
            person.Age = DateTime.Now.Year - person.Birthday.Year;
            personsList.Add(person);

        }

        public void UpdatePerson(int id, Person updatedPerson)
        {
            var person = personsList.Find(p => p.Id == id);
            if (person != null)
            {
                personsList[personsList.IndexOf(person)] = updatedPerson;
            }
        }

        public void DeletePerson(int id)
        {
            var person = personsList.Find(p => p.Id == id);
            if (person != null)
            {
                personsList.Remove(person);
            }
        }

        public List<Person> GetAllPersons()
        {
            return personsList;
        }
    }
}