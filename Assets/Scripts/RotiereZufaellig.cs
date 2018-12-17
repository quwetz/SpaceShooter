using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotiereZufaellig : MonoBehaviour {

    // Minimale und maximale Rotationsgeschwindigkeit
	public float minGeschwindigkeit;
	public float maxGeschwindigkeit;

    //Start() wird von Unity aufgerufen, wenn das Object erzeugt wird.
    void Start () {
        //Setze die Rotationsgeschwindigkeit zufällig innerhalb der angegebenen min. und max. Geschwindigkeit.
		GetComponent<Rigidbody> ().angularVelocity = Random.insideUnitSphere * Random.Range (minGeschwindigkeit, maxGeschwindigkeit);	
	}
}
