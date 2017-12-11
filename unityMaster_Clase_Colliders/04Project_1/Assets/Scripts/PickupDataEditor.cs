using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

[CustomEditor (typeof(PickupData))]
public class PickupDataEditor : Editor {

	static bool showAppareance = false;
	void OnEnable(){
		PickupData pickupData = (PickupData)target;
		if (pickupData.materials == null) {
			pickupData.materials = new Material[1];

		}
	}

	public override void OnInspectorGUI(){
		PickupData pickupData = (PickupData)target;
		pickupData.energy = EditorGUILayout.FloatField ("Energy", pickupData.energy);
		showAppareance = EditorGUILayout.Foldout (showAppareance, "Appearance");
		if (showAppareance) {
			pickupData.mesh = (Mesh)EditorGUILayout.ObjectField (new GUIContent ("Mesh:"), pickupData.mesh, typeof(Mesh), false);
			pickupData.sound = (AudioClip)EditorGUILayout.ObjectField (new GUIContent ("Sound:"), pickupData.sound, typeof(AudioClip), false);
			EditorGUILayout.LabelField ("Materiales:");
			EditorGUILayout.BeginHorizontal ();
			if (GUILayout.Button ("Add")) {
				Array.Resize (ref pickupData.materials, pickupData.materials.Length + 1);
			}
			if (pickupData.materials.Length > 1) {

				if (GUILayout.Button ("Remove")) {
					Array.Resize (ref pickupData.materials, pickupData.materials.Length - 1);
				}
			}
			EditorGUILayout.EndHorizontal ();
			for (int i = 0; i < pickupData.materials.Length; i++) {
					pickupData.materials [i] = (Material)EditorGUILayout.ObjectField (pickupData.materials [i], typeof(Material), false);
			}
		}
	}
}
