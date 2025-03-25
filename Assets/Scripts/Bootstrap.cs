using System;
using Data;
using Services;
using Systems;
using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    [SerializeField] private GameConfigData gameConfigData;
    [SerializeField] private PlayerConfigData playerConfigData;

    [SerializeField] private GameObject gameSystems;
    
    private ConfigContext _configContext;
    private Entitas.Systems _systems;
    
    private void Awake()
    {
        var contexts = Contexts.sharedInstance;
        _configContext = contexts.config;

        _systems = new Feature("Systems");
        _systems.Add(new InputSystem(contexts, new InputService(gameConfigData.InputActionAsset)));
        
        LoadConfig();
    }

    private void Start()
    {
        _systems.Initialize();
    }

    private void Update()
    {
        _systems.Execute();
    }

    private void LoadConfig()
    {
        _configContext.SetComponentsConfigConfig(gameConfigData, playerConfigData);
    }

    private void OnDestroy()
    {
        _systems.TearDown();
    }
}
