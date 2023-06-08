namespace ITAcademy
{
    public interface ILocalization
    {
        string Translate(string key, params object[] args);
    }
}