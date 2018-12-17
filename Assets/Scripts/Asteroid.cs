using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//  Da in dieser Klasse eine Referenz auf den GameController benötigt wird, erbt sie von "BrauchtGameController".
//  Dadurch steht die Methode SetzeGameControllerReferenz() und die protected Variable gameController hier zur Verfügung.
public class Asteroid : BrauchtGameController {

    //Die Geschwindigkeit mit der die Asteroiden fliegen
    public float geschwindigkeit;

    //Rotationsgeschwindigkeit
    public float rotationsGeschwindigkeit;

    //Der Sound der bei der Zerstörung eines Asteroiden abgespielt wird.
    //  public AudioClip explosionsSound;

    //Referenz auf den Rigidbody
     private Rigidbody rb;




    //Start() wird von Unity aufgerufen, wenn das Object erzeugt wird.
    void Start(){



        //Setze die Referenz auf den Rigidbody
        rb = GetComponent<Rigidbody> ();

        //SetzeGameControllerReferenz();

        //Setze die Geschwindigkeit
        rb.velocity = new Vector3 (0, 0, -geschwindigkeit);

        rb.angularVelocity = Random.insideUnitSphere * rotationsGeschwindigkeit;

        
    }
/*
    //OnTriggerEnter() wird von Unity aufgerufen, wenn ein anderer Collider mit dem eigenen Collider kollidiert.
    void OnTriggerEnter(Collider other)
    {
        //Überprüfe ob das andere Objekt ein Geschoß ist.
        if (other.tag == "Geschoß")
        {

            //Lösche das Geschoß
            Destroy(other.gameObject);

            //Spiele den explosionsSound ab
            gameController.SpieleSound(explosionsSound, 0.2f);

            //erhöhe den Punktestand
            gameController.ErhoehePunktestand(10);

            //Lösche den Asteroiden selbst
            Destroy(gameObject);
        }
    } */
}