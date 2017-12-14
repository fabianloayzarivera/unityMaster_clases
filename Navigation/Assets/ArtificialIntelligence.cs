using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ArtificialIntelligence : MonoBehaviour {

	NavMeshAgent agent;
	public GameObject goal;
	void Start () {
		agent = GetComponent<NavMeshAgent> ();
		if (agent) {
			if (goal) {
				agent.SetDestination (goal.transform.position);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
