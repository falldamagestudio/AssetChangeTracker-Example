using UnityEditor;

/// <summary>
/// Initialization logic for the asset database listener.
/// This ensures that the asset database listener is registered whenever Unity loads (or reloads) the Editor code.
/// </summary>
[InitializeOnLoad]
public static class GlobalDemoAssetListener
{
    static DemoAssetListener Instance;

    static GlobalDemoAssetListener()
    {
        Instance = new DemoAssetListener();
        AssetChangeTracker.GlobalAssetChangeTracker.AddListener(typeof(DemoScriptableObject), Instance);
    }
}
