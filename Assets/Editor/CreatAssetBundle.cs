using UnityEditor;
using UnityEngine;
using System.IO;

public class CreatAssetBundle
{
    [MenuItem("Assets/ Build AssetBundles")]
    static void BulidAllAssetBundles(){
        string assetBundleDirectory="Assets/StreamingAssets";
        if(!Directory.Exists(Application.streamingAssetsPath)){
            Directory.CreateDirectory(assetBundleDirectory);
        }
        BuildPipeline.BuildAssetBundles(assetBundleDirectory,BuildAssetBundleOptions.None,EditorUserBuildSettings.activeBuildTarget);
    }
}
