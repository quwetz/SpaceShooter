using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//  In dieser Klasse wird die Funktion SetzeGameControllerReferenz zur Verfügung gestellt.
//  Diese Klasse soll Parent-Klasse von allen Objekten sein, die eine Referenz auf den Gamecontroller benötigen, damit diese auf die Funktion zugreifen können.
public abstract class BrauchtGameController : MonoBehaviour {

    protected GameController gameController;

    //  Diese Funktion versucht einen Gamecontroller zu finden und die Variable gameController zu initialisieren.
    //  Falls kein GameController gefunden wird, wird das Spiel mit einer Fehlermeldung beendet.
    protected void SetzeGameControllerReferenz()
    {

        //Suche nach dem GameController
        GameObject potenziellerGameController = GameObject.FindWithTag("GameController");

        //Falls kein GameController gefunden wurde ist potenziellerGameController == null
        if (potenziellerGameController != null)
        {
            //GameController gefunden! :) Setze die Referenz auf den GameController
            gameController = potenziellerGameController.GetComponent<GameController>();
        }
        else
        {
            //Kein GameController gefunden. Gib eine Fehlermeldung aus.
            Debug.LogError("Cannot find GameController Script");

            //Beende das Spiel
            Application.Quit();
        }
    }
}
