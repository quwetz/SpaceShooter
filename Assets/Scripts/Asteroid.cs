using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour {

	public float speed;
    public AudioClip explosionSound;

    private AudioSource audioSource;
    private Rigidbody rb;
    private GameController gameController;

    

	void Start(){
		rb = GetComponent<Rigidbody> ();
        audioSource = GetComponent<AudioSource>();
		rb.velocity = new Vector3 (0, 0, -speed);

        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if(gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        } else
        {
            Debug.Log("Cannot find GameController Script");
        }
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "Projectile") {
			Destroy (other.gameObject);
            PlayDestructionSound();
            gameController.AddScore(10);
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