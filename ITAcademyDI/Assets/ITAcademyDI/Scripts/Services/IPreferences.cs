namespace ITAcademy
{
    public interface IPreferences
    {
        void SetString(string key, string value);
        string GetString(string key);
        void RemoveKey(string key);
        void Save();
        void Clear();
    }
}