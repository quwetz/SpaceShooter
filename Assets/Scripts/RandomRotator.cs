using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour {

	public float tumbleMin;
	public float tumbleMax;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody> ().angularVelocity = Random.insideUnitSphere * Random.Range (tumbleMin, tumbleMax);	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
