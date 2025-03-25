using UnityEngine;
using UnityEngine.InputSystem;

namespace Data
{
    [CreateAssetMenu(fileName = "NewGameConfig", menuName = "Data/Config/Game", order = 0)]
    public sealed class GameConfigData : ScriptableObject
    {
        [field: SerializeField] public InputActionAsset InputActionAsset { get; private set; }
    }
}