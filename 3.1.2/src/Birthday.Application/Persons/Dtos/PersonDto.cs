using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.ComponentModel.DataAnnotations;

namespace Birthday.Persons.Dtos
{

    [AutoMapFrom(typeof(Person))]
    public class PersonDto: EntityDto<Guid>
    {
        [Required]
        [MaxLength(Person.MaxNameLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(Person.MaxRelationShipLength)]
        public string RelationShip { get; set; }

        [Required]
        public DateTime Birthday_Lunar { get; set; }

        [Required]
        public DateTime Birthday_Solar { get; set; }

        [Required]
        [Phone]
        public string PhoneNum { get; set; }

    }    
}
