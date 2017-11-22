using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Birthday.Persons;
using Birthday.Persons.Dtos;
using Birthday.Web.Models.Person;

namespace Birthday.Web.Controllers
{
    public class BirthdayController : BirthdayControllerBase
    {
        private readonly IPersonService _personService;

        public BirthdayController(IPersonService personService)
        {
            _personService = personService;
        }

        public async Task<ActionResult> Index(GetAllPersonsInput input)
        {
            var output = await _personService.GetAll(input);

            var model = new IndexViewModel(output.Items);

            return View(model);
        }

        public async Task<ActionResult> Create() => View();


        public async Task<ActionResult>Update()
    }
}