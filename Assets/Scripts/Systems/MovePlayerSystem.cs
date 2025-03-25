using Entitas;

namespace Systems
{
    public sealed class MovePlayerSystem : IExecuteSystem
    {
        private readonly GameContext _gameContext;

        public MovePlayerSystem(Contexts contexts)
        {
            _gameContext = contexts.game;
        }
        
        public void Execute()
        {
            var player = _gameContext.componentsGamePlayerEntity;
            player.componentsGamePhysicsView.value.linearVelocity = player.componentsGameMoveDirection.value;
        }
    }
}