using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

namespace Components.Input
{
    [Input, Unique]
    public sealed class MoveInputComponent : IComponent
    {
        public Vector2 value;
    }
}