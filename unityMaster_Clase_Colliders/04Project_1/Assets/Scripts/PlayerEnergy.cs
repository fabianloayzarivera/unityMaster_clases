using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEnergy : MonoBehaviour {

	public float energy = 100;
	void Start () {
		if (energy <= 0) {
			energy = 100;
		}
	}

	public void Apply(float value){
		energy += value;
		gameObject.transform.localScale = (energy / 100.0f) * Vector3.one;
	
	
	}
}
