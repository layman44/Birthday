using Birthday.EntityFrameworkCore;

namespace Birthday.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly BirthdayDbContext _context;

        public TestDataBuilder(BirthdayDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}