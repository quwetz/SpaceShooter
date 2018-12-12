using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody rb;
    public float maxSpeed = 10.0f;
    public float minX = -5.0f;
    public float maxX = 5.0f;
    public float minZ = -10.0f;
    public float maxZ = 10.0f;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {

        float moveHorizontal = Input.GetAxis("Horizontal") * maxSpeed;
        float moveVertical = Input.GetAxis("Vertical") * maxSpeed;

        rb.velocity = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.position = new Vector3(Mathf.Clamp(rb.position.x, minX, maxX), 0, Mathf.Clamp(rb.position.z, minZ, maxZ));
    }
}
