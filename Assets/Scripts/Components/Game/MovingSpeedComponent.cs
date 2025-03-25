using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace Components.Game
{
    [Game, Unique]
    public sealed class MovingSpeedComponent : IComponent
    {
        public float value;
    }
}