using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MakePickupData : MonoBehaviour {

	[MenuItem("Assets/Create/PickupData")]
	public static void CreatePickupDataAsset(){
	
		PickupData data = ScriptableObject.CreateInstance<PickupData> ();
		AssetDatabase.CreateAsset (data, "Assets/Resources/NewPickupData.asset");
		AssetDatabase.SaveAssets ();

	}
}
