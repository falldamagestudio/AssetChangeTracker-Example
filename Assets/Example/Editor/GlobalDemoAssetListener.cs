using UnityEditor;

[InitializeOnLoad]
public static class GlobalDemoAssetListener
{
    static DemoAssetListener Instance;

    static GlobalDemoAssetListener()
    {
        Instance = new DemoAssetListener();
        GlobalAssetChangeTracker.AddListener(typeof(DemoScriptableObject), Instance);
    }
}
