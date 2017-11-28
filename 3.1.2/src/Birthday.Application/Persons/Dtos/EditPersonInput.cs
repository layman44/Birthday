using Abp.AutoMapper;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Runtime.Validation;
using System;
using System.ComponentModel.DataAnnotations;

namespace Birthday.Persons.Dtos
{
    [AutoMapTo(typeof(Person))]
    public class EditPersonInput: Entity<Guid>, IHasModificationTime, ICustomValidate
    {
        [Required]
        [MaxLength(Person.MaxNameLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(Person.MaxRelationShipLength)]
        public string RelationShip { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Birthday_Lunar { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Birthday_Solar { get; set; }

        [Required]
        [Phone]
        public string PhoneNum { get; set; }

        public DateTime? LastModificationTime { get; set; }

        public void AddValidationErrors(CustomValidationContext context)
        {
            
        }
    }
}
