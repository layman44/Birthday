using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Birthday.Web.Models.Person
{
    public class CreatePersonViewModel
    {
        public Persons.Person Person { get; set; }

        public CreatePersonViewModel(Persons.Person person)
        {
            Person = person;
        }

    }
}
