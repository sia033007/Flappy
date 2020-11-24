using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class AssetScript : Editor
{
   [MenuItem("Assets/ Build AssetBundle")]
   static void BuildAssetBundles(){
       BuildPipeline.BuildAssetBundles(@"C:\Users\HeisenBerg\Desktop\AssetBundles",BuildAssetBundleOptions.ChunkBasedCompression,BuildTarget.Android);
       
   }

}
