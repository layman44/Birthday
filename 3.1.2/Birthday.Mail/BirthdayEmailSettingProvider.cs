using Abp.Configuration;
using Abp.Localization;
using Abp.Net.Mail;
using System;
using System.Collections.Generic;
using System.Text;

namespace Birthday.Mail
{
    public class BirthdayEmailSettingProvider : SettingProvider
    {
        public override IEnumerable<SettingDefinition> GetSettingDefinitions(SettingDefinitionProviderContext context)
        {
            return new[]
            {
                new SettingDefinition(EmailSettingNames.Smtp.Host, "smtp.qq.com", L("SmtpHost"),
                    scopes: SettingScopes.Application | SettingScopes.Tenant),

                new SettingDefinition(EmailSettingNames.Smtp.Port, "465", L("SmtpPort"),
                    scopes: SettingScopes.Application | SettingScopes.Tenant),

                new SettingDefinition(EmailSettingNames.Smtp.UserName, "348702974@qq.com", L("Username"),
                    scopes: SettingScopes.Application | SettingScopes.Tenant),

                new SettingDefinition(EmailSettingNames.Smtp.Password, "psqztlylazjrbija", L("Password"),
                    scopes: SettingScopes.Application | SettingScopes.Tenant),

                new SettingDefinition(EmailSettingNames.Smtp.Domain, "smtp.qq.com", L("DomainName"),
                    scopes: SettingScopes.Application | SettingScopes.Tenant),

                new SettingDefinition(EmailSettingNames.Smtp.EnableSsl, "true", L("UseSSL"),
                    scopes: SettingScopes.Application | SettingScopes.Tenant),

                new SettingDefinition(EmailSettingNames.Smtp.UseDefaultCredentials, "false", L("UseDefaultCredentials"),
                    scopes: SettingScopes.Application | SettingScopes.Tenant),

                new SettingDefinition(EmailSettingNames.DefaultFromAddress, "MyDefaultFromAddress",
                    L("DefaultFromSenderEmailAddress"), scopes: SettingScopes.Application | SettingScopes.Tenant),

                new SettingDefinition(EmailSettingNames.DefaultFromDisplayName, "MyDefaultFromDisplayName",
                    L("DefaultFromSenderDisplayName"), scopes: SettingScopes.Application | SettingScopes.Tenant)
            };
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, BirthdayConsts.LocalizationSourceName);
        }

    }
}
