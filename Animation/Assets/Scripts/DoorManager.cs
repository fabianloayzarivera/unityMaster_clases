using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour {

	// Use this for initialization
	Animator animator;
	void Start () {
		animator = GetComponent<Animator> ();
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider collider) {
        animator.SetBool("IsOpen", true);
    }

    void OnTriggerExit(Collider collider)
    {
        animator.SetBool("IsOpen", false);
    }
}
