using DemoLibrary.Models;

namespace DemoLibrary.DataAccess
{
    public interface IDataAcess
    {
        public List<PersonModel> GetPeople();

        public PersonModel InsertPeson(string firstname, string lastName);
    }
}