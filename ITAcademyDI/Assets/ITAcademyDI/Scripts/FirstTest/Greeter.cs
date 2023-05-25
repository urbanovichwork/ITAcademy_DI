using System;
using UnityEngine;
using Zenject;

namespace ITAcademy
{
    public class Greeter : IInitializable, ITickable, IDisposable
    {
        private readonly string _message;

        public Greeter(string message)
        {
            _message = message;
        }

        public void Initialize()
        {
        }

        public void Tick()
        {
        }

        public void Dispose()
        {
        }
    }
}