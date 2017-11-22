using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Birthday.Persons.Dtos
{
    [AutoMapTo(typeof(Person))]
    public class CreatePersonInput
    {
        [Required]
        [MaxLength(Person.MaxNameLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(Person.MaxRelationShipLength)]
        public string RelationShip { get; set; }

        [Required]
        public DateTime Birthday { get; set; }

        public string PhoneNum { get; set; }

    }
}
