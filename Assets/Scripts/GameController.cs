using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


[System.Serializable]
public static class Boundary {
	public static float minX = -5.3f;
	public static float maxX = 5.3f;
	public static float minZ = -2.7f;
	public static float maxZ = 15.0f;
}


public class GameController : MonoBehaviour {

	//The time between the spawning of two subsequent asteroids
	public float spawnWait;

	//The time at which the next asteroid should be spawned
	private float nextSpawn;

	//The asteroid gameObject
	public GameObject Asteroid;

    public Text scoreText;
    public Text restartText;
    public Text gameOverText;

    private bool gameOver;

    private int score;

	// Use this for initialization
	void Start () {
		//start spawning aseroids after 3 seconds
		nextSpawn = Time.time + 3;

        score = 0;
        UpdateScore();
        
        gameOverText.text = "";
        restartText.text = "";
	}
	
	// Update is called once per frame
	void Update () {

        if(gameOver && Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene("Level1");
        }

		if (Time.time >= nextSpawn) {
			SpawnAsteroid ();
			nextSpawn = Time.time + spawnWait;
		}
	}
		
	private GameObject SpawnAsteroid(){
		Vector3 spawnPosition = new Vector3 (Random.Range(Boundary.minX, Boundary.maxX),0,Boundary.maxZ + 2);
		Quaternion spawnRotation = Quaternion.identity;
		return Instantiate (Asteroid, spawnPosition, spawnRotation);
	}

    void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }

    public void AddScore(int scoreValue)
    {
        score += scoreValue;
        UpdateScore();
    }

    public void GameOver()
    {
        gameOver = true;
        gameOverText.text = "Game Over";
        restartText.text = "Press 'r' for Restart";
    }
}
