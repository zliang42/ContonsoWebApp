using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Data;
using Contoso.Model;

namespace Contoso.Service
{
    public class PeopleService
    {
        public List<People> GetAllPeople()
        {
            PeopleRepository repository = new PeopleRepository();
            var People = repository.GetAll();
            return People;

        }

        public void SavePerson(People pl)
        {
            PeopleRepository repository = new PeopleRepository();
            repository.CreateNew(pl);
        }

        public People GetPersonById(int id)
        {
            PeopleRepository repository = new PeopleRepository();
            return repository.GetById(id);

        }

        public void DeletePerson (int id)
        {
            PeopleRepository repository = new PeopleRepository();
            repository.DeleteById(id);
        }

        public void UpdatePerson (People person)
        {
            PeopleRepository reporisory = new PeopleRepository();
            reporisory.Update(person);
        }
    }
}
