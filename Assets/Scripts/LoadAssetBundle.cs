using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssetBundle : MonoBehaviour
{
    AssetBundle myassetbundle;
    public string path;
    public string bundlename;
    // Start is called before the first frame update
    void Start()
    {
        LoadAsset(path);
        InstantiateBundle(bundlename);
    }
    void LoadAsset(string asseturl){
        myassetbundle=AssetBundle.LoadFromFile(asseturl);
        Debug.Log(myassetbundle==null ?"AssetBundle failed to load" :"AssetBundle successfully loaded");

    }
    void InstantiateBundle(string assetname){
        var prefab=myassetbundle.LoadAsset(assetname);
        Instantiate(prefab);
    }

}
