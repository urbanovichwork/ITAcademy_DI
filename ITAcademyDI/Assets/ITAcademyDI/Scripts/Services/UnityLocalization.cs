using UnityEngine.Localization.Settings;

namespace ITAcademy
{
    public class UnityLocalization : ILocalization
    {
        public string Translate(string key, params object[] args)
        {
            string localizedString =
                LocalizationSettings.StringDatabase.GetLocalizedString(LocalizationSettings.StringDatabase.DefaultTable,
                    key, arguments: args);

            return localizedString;
        }
    }
}