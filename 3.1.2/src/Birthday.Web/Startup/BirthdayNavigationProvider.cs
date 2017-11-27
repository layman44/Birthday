using Abp.Application.Navigation;
using Abp.Localization;

namespace Birthday.Web.Startup
{
    /// <summary>
    /// This class defines menus for the application.
    /// </summary>
    public class BirthdayNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        PageNames.PersonList,
                        L("PersonList"),
                        url: "Birthday/Index",
                        icon: "fa fa-home"
                        )
                );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, BirthdayConsts.LocalizationSourceName);
        }
    }
}
