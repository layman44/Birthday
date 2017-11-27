using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Birthday.Persons.Dtos;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Microsoft.EntityFrameworkCore;
using Birthday.Mail;

namespace Birthday.Persons
{
    public class PersonService : BirthdayAppServiceBase, IPersonService
    {
        private readonly IRepository<Person, Guid> _personRepository;

        private readonly IMailSendManager _mailSendManager;

        public PersonService(IRepository<Person, Guid> personRepository, IMailSendManager mailSendManager)
        {
            _personRepository = personRepository;
            _mailSendManager = mailSendManager;
            //test
            _mailSendManager.SendMail();
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

        public async Task<bool> Update(EditPersonInput input)
        {
            var person = await _personRepository.GetAsync(input.Id);

            ObjectMapper.Map(input, person);

            await _personRepository.UpdateAsync(person);

            return true;
        }

        public async Task<PersonDto> GetPersonById(Guid id)
        {
            var person = await _personRepository.GetAsync(id);

            var dto = ObjectMapper.Map<PersonDto>(person);

            return ObjectMapper.Map<PersonDto>(person);
        }

        public async Task<bool> Delete(Guid id)
        {
            var person = await _personRepository.GetAsync(id);

            if (person == null)
            {
                throw new Abp.AbpException(L("DeleteFailed"));
            }
            await _personRepository.DeleteAsync(id);

            return true;
        }
    }
}
