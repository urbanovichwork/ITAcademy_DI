using JetBrains.Annotations;
using UnityEngine;

namespace ITAcademy
{
    [UsedImplicitly]
    public class UnityPreferences : IPreferences
    {
        void IPreferences.SetString(string key, string value) => PlayerPrefs.SetString(key, value);
        string IPreferences.GetString(string key) => PlayerPrefs.GetString(key);
        void IPreferences.RemoveKey(string key) => PlayerPrefs.DeleteKey(key);
        void IPreferences.Save() => PlayerPrefs.Save();
        void IPreferences.Clear() => PlayerPrefs.DeleteAll();
    }
}