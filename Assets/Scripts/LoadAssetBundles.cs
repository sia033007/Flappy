using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssetBundles : MonoBehaviour
{
    AssetBundle myassetbundle;
    public string path;
    public string fbxname;
    // Start is called before the first frame update
    void Start()
    {
        LoadAssetBundle(path);
        InstantiateAssetBundle(fbxname);
    }
    void LoadAssetBundle(string asseturl){
        myassetbundle=AssetBundle.LoadFromFile(asseturl);
        Debug.Log(myassetbundle == null ? "Failed To Load AssetBundle":"AssetBundle Successfully Loaded");

    }
    void InstantiateAssetBundle(string bundlename){
        var prefab=myassetbundle.LoadAsset(bundlename);
        Instantiate(prefab);
    }
}
