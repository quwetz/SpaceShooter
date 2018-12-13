using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour {

	public float speed;
	private Rigidbody rb;

	void Start(){
		rb = GetComponent<Rigidbody> ();
		rb.velocity = new Vector3 (0, 0, -speed);
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "Projectile") {
			Destroy (other.gameObject);
			Destroy (gameObject);
		} else if (other.tag == "Player") {
			Destroy (other.gameObject);
		}
	}
}