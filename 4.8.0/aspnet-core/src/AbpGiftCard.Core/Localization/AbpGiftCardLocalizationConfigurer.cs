using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace AbpGiftCard.Localization
{
    public static class AbpGiftCardLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(AbpGiftCardConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(AbpGiftCardLocalizationConfigurer).GetAssembly(),
                        "AbpGiftCard.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
