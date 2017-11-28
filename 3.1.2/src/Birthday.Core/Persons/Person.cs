using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Birthday.Persons
{
    [Table("Person")]
    public class Person : Entity<Guid>, IHasCreationTime,IHasModificationTime
    {
        public const int MaxNameLength = 32;
        public const int MaxRelationShipLength = 32;

        [Required]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(MaxRelationShipLength)]
        public string RelationShip { get; set; }

        /// <summary>
        /// 农历
        /// </summary>
        [Required]
        [DataType(DataType.Date)]
        public DateTime Birthday_Lunar{ get; set; }

        /// <summary>
        /// 阳历
        /// </summary>
        [Required]
        [DataType(DataType.Date)]
        public DateTime Birthday_Solar { get; set; }

        public string PhoneNum { get; set; }

        public DateTime CreationTime { get; set; }

        public DateTime? LastModificationTime { get; set; }

        public Person()
        {

        }

        public Person(string name, string relationShip, DateTime birthday_lunar, DateTime birthday_solar, string phoneNum)
        {
            Name = name;
            RelationShip = relationShip;
            Birthday_Lunar = birthday_lunar;
            Birthday_Solar = birthday_solar;
            PhoneNum = phoneNum;
        }
    }
}
