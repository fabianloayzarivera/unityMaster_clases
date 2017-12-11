using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forces : MonoBehaviour {

	// Use this for initialization
	public float strenght = 100;
	bool doAddForce = false;
	Rigidbody rigidBody;
	void Start () {
		rigidBody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown(){
		Debug.Log ("Adding Force");
		doAddForce = true;
	}

	void FixedUpdate(){
		if (doAddForce) {
			rigidBody.AddForce (transform.forward * strenght, ForceMode.VelocityChange);
			doAddForce = false;
		}
	}
}
