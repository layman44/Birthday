using Abp.AutoMapper;
using System;
using System.ComponentModel.DataAnnotations;

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
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        [Required]
        [Phone]
        public string PhoneNum { get; set; }

    }
}
