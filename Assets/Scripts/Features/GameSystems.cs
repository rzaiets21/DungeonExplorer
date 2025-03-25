using System;
using Systems;
using UnityEngine;

namespace Features
{
    public sealed class GameSystems : MonoBehaviour
    {
        private Entitas.Systems _gameSystems;
        private Entitas.Systems _physicsSystems;
        
        private void Awake()
        {
            var contexts = Contexts.sharedInstance;
            _gameSystems = new Feature("Game Systems");
            _gameSystems.Add(new CreatePlayerSystem(contexts));

            _physicsSystems = new Feature("Physics Systems");
            _physicsSystems.Add(new MovePlayerSystem(contexts));
            _physicsSystems.Add(new UpdateMoveDirectionSystem(contexts));
        }

        private void Start()
        {
            _gameSystems.Initialize();
            _physicsSystems.Initialize();
        }

        private void Update()
        {
            _gameSystems.Execute();
        }

        private void FixedUpdate()
        {
            _physicsSystems.Execute();
        }
    }
}