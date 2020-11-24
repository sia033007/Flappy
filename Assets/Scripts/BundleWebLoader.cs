using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BundleWebLoader : MonoBehaviour
{
    public string bundleUrl= "https://trainbit.com/folders/9852988484/testbundle/fbx";
    public string assetname= "FBX";
    // Start is called before the first frame update
    IEnumerator Start()
    {
        using (WWW web = new WWW (bundleUrl)){
            yield return web;
            AssetBundle remoteAssetBundle=web.assetBundle;
            if(remoteAssetBundle==null){
                Debug.LogError("Falied to Download AssetBundle!");
                yield break;
            }
            Instantiate(remoteAssetBundle.LoadAsset(assetname));
            remoteAssetBundle.Unload(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
