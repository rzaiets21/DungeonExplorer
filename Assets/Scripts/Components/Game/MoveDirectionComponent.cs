using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

namespace Components.Game
{
    [Game, Unique]
    public class MoveDirectionComponent : IComponent
    {
        public Vector2 value;
    }
}