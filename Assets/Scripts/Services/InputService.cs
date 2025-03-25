using Services.Interfaces;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Services
{
    public sealed class InputService : IInputService
    {
        private readonly InputActionAsset _asset;
        private readonly InputActionMap _playerInputMap;

        private readonly InputAction _movementAction;
        
        public Vector2 Movement { get; private set; } = Vector2.zero;

        public InputService(InputActionAsset asset)
        {
            _asset = asset;

            _playerInputMap = _asset.FindActionMap("Player");
            
            _movementAction = _playerInputMap.FindAction("Move");

            _movementAction.performed += Move;
            _movementAction.canceled += Move;
            
            _playerInputMap.Enable();
        }

        private void Move(InputAction.CallbackContext ctx)
        {
            Movement = ctx.ReadValue<Vector2>();
        }
        
        public void Dispose()
        {
            if (_playerInputMap.enabled)
            {
                _playerInputMap.Disable();
            }
        }
    }
}