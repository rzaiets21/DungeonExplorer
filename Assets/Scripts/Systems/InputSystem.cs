using Entitas;
using Services.Interfaces;
using UnityEngine;

namespace Systems
{
    public sealed class InputSystem : IInitializeSystem, IExecuteSystem, ITearDownSystem
    {
        private InputContext _inputContext;
        private IInputService _inputService;
        
        public InputSystem(Contexts contexts, IInputService inputService)
        {
            _inputContext = contexts.input;
            _inputService = inputService;
        }
        
        public void Initialize()
        {
            _inputContext.SetComponentsInputMoveInput(Vector2.zero);
        }

        public void Execute()
        {
            _inputContext.ReplaceComponentsInputMoveInput(_inputService.Movement);
        }

        public void TearDown()
        {
            _inputService.Dispose();
        }
    }
}