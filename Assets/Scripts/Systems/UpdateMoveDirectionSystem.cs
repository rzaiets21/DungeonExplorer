using Entitas;
using UnityEngine;

namespace Systems
{
    public sealed class UpdateMoveDirectionSystem : IExecuteSystem
    {
        private readonly InputContext _inputContext;
        private readonly IGroup<GameEntity> _entities;

        public UpdateMoveDirectionSystem(Contexts contexts)
        {
            _inputContext = contexts.input;
            _entities = contexts.game.GetGroup(GameMatcher.AllOf(GameMatcher.ComponentsGameMoveDirection));
        }
        
        public void Execute()
        {
            foreach (var gameEntity in _entities)
            {
                var axes = _inputContext.componentsInputMoveInput.value;

                var moveDirection = axes.normalized;
                gameEntity.ReplaceComponentsGameMoveDirection(moveDirection);
                gameEntity.isComponentsGameMoving = moveDirection != Vector2.zero;
            }
        }
    }
}