using DemoLibrary.Models;

namespace DemoLibrary.DataAccess
{
    public class DemoDataAccess : IDataAcess
    {
        private List<PersonModel> people = new();

        public DemoDataAccess()
        {
            people.Add(new PersonModel{Id = 1, FirstName = "Tim", LastName="Corey"});
            people.Add(new PersonModel{Id = 2, FirstName = "Sue", LastName="Storm"});
        }

        public List<PersonModel> GetPeople()
        {
            return people;
        }

        public PersonModel InsertPeson(string firstname, string lastName)
        {
            PersonModel p = new() {FirstName = firstname, LastName = lastName};
            p.Id = people.Max(x => x.Id) + 1;

            people.Add(p);
            return p;
        }
    }
}