using UnityEngine;

namespace Services.Interfaces
{
    public interface IInputService
    {
        Vector2 Movement { get; }
        
        void Dispose();
    }
}