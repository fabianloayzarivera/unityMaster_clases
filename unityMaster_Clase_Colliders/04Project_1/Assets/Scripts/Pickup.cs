using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour {

	public PickupData pickupData;
	public AudioSource audioSource;
	private MeshRenderer renderer;
	void Start () {
		MeshFilter filter = GetComponent<MeshFilter> ();	
		if (filter) {
			filter.mesh = pickupData.mesh;
		}
		audioSource = GetComponent<AudioSource> ();
		renderer = GetComponent<MeshRenderer> ();
		if (renderer) {
			renderer.materials = pickupData.materials;
		}
	}
	

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			PlayerEnergy playerEnergy = other.gameObject.GetComponent<PlayerEnergy> ();
			if (playerEnergy) {
				playerEnergy.Apply (pickupData.energy);
			}
			if (audioSource) {
				audioSource.PlayOneShot (pickupData.sound);
				renderer.enabled = false;
				Destroy (gameObject);
				//Destroy (gameObject, pickupData.sound.length);
			} else {
				Destroy (gameObject);
			}

		}
	}
}
