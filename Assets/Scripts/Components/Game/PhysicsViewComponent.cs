using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

namespace Components.Game
{
    [Game, Unique]
    public sealed class PhysicsViewComponent : IComponent
    {
        public Rigidbody2D value;
    }
}