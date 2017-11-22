﻿using Birthday.Persons.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Birthday.Web.Models.Person
{
    public class IndexViewModel
    {
        public IReadOnlyList<PersonListDto> Persons { get;}

        public IndexViewModel(IReadOnlyList<PersonListDto> persons)
        {
            Persons = persons;
        }
    }
}
