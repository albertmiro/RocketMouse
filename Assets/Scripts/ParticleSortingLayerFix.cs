using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSortingLayerFix : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.GetComponent<ParticleSystem> ().GetComponent<Renderer> ().sortingLayerName = "Player";
		transform.GetComponent<ParticleSystem> ().GetComponent<Renderer> ().sortingOrder = -1;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
