using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : MonoBehaviour {

	private Rigidbody rb;
	public float speed = 15;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		rb.velocity = new Vector3(0,0,speed);
	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
