using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

namespace Components.Game
{
    [Game, Unique]
    public sealed class GameViewComponent : IComponent
    {
        public GameObject gameObject;
        public Transform transform;
    }
}