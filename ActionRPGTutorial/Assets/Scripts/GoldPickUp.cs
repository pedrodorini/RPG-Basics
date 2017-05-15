using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldPickUp : MonoBehaviour {

    public int value;
    private MoneyManager theMM;


	// Use this for initialization
	void Start () {
        theMM = FindObjectOfType<MoneyManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.name == "Player") {
            theMM.addMoney(value);
            Destroy(gameObject);
        }
    }
}
