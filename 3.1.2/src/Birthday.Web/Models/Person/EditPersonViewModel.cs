namespace Birthday.Web.Models.Person
{
    public class EditPersonViewModel
    {
        public Persons.Dtos.PersonDto PersonDto{ get; set; }

        public EditPersonViewModel(Persons.Dtos.PersonDto personDto)
        {
            PersonDto = personDto;
        }
    }
}
