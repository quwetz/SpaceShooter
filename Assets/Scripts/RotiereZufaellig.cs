using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotiereZufaellig : MonoBehaviour {

    // Minimale und maximale Rotationsgeschwindigkeit
	public float minGeschwindigkeit;
	public float maxGeschwindigkeit;

    // Start() wird von Unity aufgerufen, wenn das Object erzeugt wird.
    void Start () {

        // Ermittle eine zufällige Rotationsgeschwindigkeit innerhalb der min. und max. Geschwindigkeit
        float rotationsgeschwindigkeit = Random.Range(minGeschwindigkeit, maxGeschwindigkeit);

        GetComponent<Rigidbody> ().angularVelocity = Random.insideUnitSphere * rotationsgeschwindigkeit;	
	}
}
