using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using System;

namespace Birthday.Persons.Dtos
{
    [AutoMapFrom(typeof(Person))]
    public class PersonListDto : EntityDto<Guid>, IHasCreationTime
    {
        public string Name { get; set; }

        public string RelationShip { get; set; }

        public DateTime Birthday { get; set; }

        public string PhoneNum { get; set; }

        public DateTime CreationTime { get; set; }
    }
}
