using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
	//Player components we need to access from this script
	private Rigidbody rb;

	//The place where our shots start
	public Transform ShotSpawn;

	//The gameobject we use for shooting
	public GameObject shot;

	//The minimum time between two subsequent shots
	public float reloadTime;

	//The point in time the player is allowed to shoot 
	//(the player is allowed to shoot if nextShot is smaller than the gametime)
	private float nextShot;
    
	//The maximum horizontal and vertical speed of the player
	public float maxSpeed;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody> ();
		nextShot = Time.time;
    }


	void Update(){
		if(Input.GetButton("Fire1")){
			Shoot();
		}
	}

    void FixedUpdate()
    {
		//Set the Velocity
        float moveHorizontal = Input.GetAxis("Horizontal") * maxSpeed;
        float moveVertical = Input.GetAxis("Vertical") * maxSpeed;

        rb.velocity = new Vector3(moveHorizontal, 0.0f, moveVertical);


		//Clamp the position into the Screen
        rb.position = new Vector3(Mathf.Clamp(rb.position.x, Boundary.minX, Boundary.maxX), 0, Mathf.Clamp(rb.position.z, Boundary.minZ, Boundary.maxZ));
	
		//Set Rotation in relation to the horizontal speed
		rb.rotation = Quaternion.AngleAxis(-90, new Vector3(1,0,0)) * Quaternion.AngleAxis (35 * Input.GetAxis ("Horizontal"), new Vector3 (0, 1, 0));

	}

	void Shoot(){
		if (nextShot < Time.time) {
			Instantiate (shot, ShotSpawn.position, Quaternion.identity);
			nextShot = Time.time + reloadTime;
		}
	}
}