using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupPoint : MonoBehaviour {
    public GameManager gameManager;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Point")
        {
            Debug.Log("Collided");
            gameManager.AddPoints(1);
            other.gameObject.SetActive(false);
        }
    }

}
