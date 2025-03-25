using UnityEngine;

namespace Data
{
    [CreateAssetMenu(fileName = "NewPlayerConfig", menuName = "Data/Config/Player", order = 0)]
    public sealed class PlayerConfigData : ScriptableObject
    {
        [field: SerializeField] public GameObject PlayerPrefab { get; private set; }
        [field: SerializeField] public float Speed { get; private set; }
    }
}