using UnityEngine;

namespace ITAcademy
{
    public class GreeterSecond
    {
        private string hello = "hello";
        
        public GreeterSecond(string message, string a, string b, string c, Greeter greeter)
        {
            Debug.Log($"Constructor Second {greeter.GetType()} " + message + a + b + c);
        }
    }
}