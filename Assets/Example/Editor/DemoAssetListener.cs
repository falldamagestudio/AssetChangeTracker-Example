using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Example asset database listener.
/// This will print to the console log whenever assets of the appropriate type are added / changed / moved / deleted.
/// </summary>
public class DemoAssetListener : AssetChangeTracker.IListener
{
    public void OnExists(HashSet<string> assetPaths)
    {
        Debug.Log("Existing assets at initialization time:");
        foreach (string assetPath in assetPaths)
            Debug.Log("---- " + assetPath);
    }

    public void OnAdded(string assetPath)
    {
        Debug.Log("New asset added: " + assetPath);
    }

    public void OnChanged(string assetPath)
    {
        Debug.Log("Existing asset changed: " + assetPath);
    }

    public void OnMoved(string assetSourcePath, string assetTargetPath)
    {
        Debug.Log("Existing asset moved from " + assetSourcePath + " to " + assetTargetPath);
    }

    public void OnDeleted(string assetPath)
    {
        Debug.Log("Existing asset deleted: " + assetPath);
    }
}
