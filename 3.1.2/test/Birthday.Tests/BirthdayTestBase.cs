using System;
using System.Threading.Tasks;
using Abp.TestBase;
using Birthday.EntityFrameworkCore;
using Birthday.Tests.TestDatas;

namespace Birthday.Tests
{
    public class BirthdayTestBase : AbpIntegratedTestBase<BirthdayTestModule>
    {
        public BirthdayTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<BirthdayDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<BirthdayDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<BirthdayDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<BirthdayDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<BirthdayDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<BirthdayDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<BirthdayDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<BirthdayDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
