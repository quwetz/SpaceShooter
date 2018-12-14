using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour {

	public float speed;
    public AudioClip explosionSound;

    private AudioSource audioSource;
    private Rigidbody rb;


    

	void Start(){
		rb = GetComponent<Rigidbody> ();
        audioSource = GetComponent<AudioSource>();
		rb.velocity = new Vector3 (0, 0, -speed);
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "Projectile") {
			Destroy (other.gameObject);
            PlayDestructionSound();
			Destroy (gameObject);
		}
	}

    void PlayDestructionSound()
    {
        GameObject soundObject = new GameObject();
        AudioSource sound = soundObject.AddComponent<AudioSource>() as AudioSource;
        sound.PlayOneShot(explosionSound, 0.2f);
        Destroy(soundObject, explosionSound.length);
    }
}