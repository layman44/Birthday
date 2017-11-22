using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Birthday.Persons.Dtos;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Birthday.Persons
{
    public class PersonService : BirthdayAppServiceBase, IPersonService
    {
        private readonly IRepository<Person, Guid> _personRepository;

        public PersonService(IRepository<Person, Guid> personRepository)
        {
            _personRepository = personRepository;
        }

        public async Task Create(CreatePersonInput input)
        {
            var person = ObjectMapper.Map<Person>(input);
            await _personRepository.InsertAsync(person);
        }

        public async Task<ListResultDto<PersonListDto>> GetAll(GetAllPersonsInput input)
        {
            var persons = await _personRepository.GetAll().WhereIf(input != null && input.Name != null, t => t.Name.Contains(input.Name)).ToListAsync();

            return new ListResultDto<PersonListDto>(ObjectMapper.Map<List<PersonListDto>>(persons));
        }
    }
}
