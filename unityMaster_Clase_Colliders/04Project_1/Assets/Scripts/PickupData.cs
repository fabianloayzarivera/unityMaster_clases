using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupData : ScriptableObject {
	public float energy;
	public Mesh mesh;
	public AudioClip sound;
	public Material[] materials;
}
