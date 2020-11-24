using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class BundledObjectLoader : MonoBehaviour
{
    public string assetname= "BundledSpriteObject";
    public string bundlename= "testbundle";
    // Start is called before the first frame update
    void Start()
    {
      AssetBundle localAssetBundle=AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath,bundlename));
      if(localAssetBundle==null){
          Debug.LogError("Falied to load AssetBundle!");
          return;
      } 
      GameObject asset=localAssetBundle.LoadAsset<GameObject>(assetname);
      Instantiate(asset);
      localAssetBundle.Unload(false); 
    }
}
