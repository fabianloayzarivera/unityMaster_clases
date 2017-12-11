using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	public float speed = 5;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");

		gameObject.transform.position += v * Vector3.forward * Time.deltaTime * speed;
		gameObject.transform.position += h * Vector3.right * Time.deltaTime * speed;
	}
}
