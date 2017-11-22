using Abp.Application.Services.Dto;
using Birthday.Persons.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Birthday.Persons
{
    public interface IPersonService
    {
        Task Create(CreatePersonInput input);

        Task<ListResultDto<PersonListDto>> GetAll(GetAllPersonsInput input);
    }
}
