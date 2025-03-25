using Entitas;
using Entitas.Unity;
using UnityEngine;

namespace Systems
{
    public sealed class CreatePlayerSystem : IInitializeSystem
    {
        private readonly GameContext _gameContext;
        private readonly ConfigContext _configContext;

        public CreatePlayerSystem(Contexts contexts)
        {
            _gameContext = contexts.game;
            _configContext = contexts.config;
        }
        
        public void Initialize()
        {
            _gameContext.isComponentsGamePlayer = true;
            
            var playerData = _configContext.componentsConfigConfig.playerConfig;

            var playerView = Object.Instantiate(playerData.PlayerPrefab, Vector3.zero, Quaternion.identity);
            var player = _gameContext.componentsGamePlayerEntity;
            
            player.AddComponentsGameGameView(playerView, playerView.transform);
            player.AddComponentsHealth(100);
            player.AddComponentsGameMovingSpeed(playerData.Speed);
            player.AddComponentsGamePhysicsView(playerView.GetComponent<Rigidbody2D>());
            player.AddComponentsGameMoveDirection(Vector2.zero);

            player.isComponentsGameMoving = false;

            playerView.Link(player);
        }
    }
}