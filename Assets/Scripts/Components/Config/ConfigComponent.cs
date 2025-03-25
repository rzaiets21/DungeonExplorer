using Data;
using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace Components.Config
{
    [Config, Unique]
    public sealed class ConfigComponent : IComponent
    {
        public GameConfigData gameConfig;
        public PlayerConfigData playerConfig;
    }
}