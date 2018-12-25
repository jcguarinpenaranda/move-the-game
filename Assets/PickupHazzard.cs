using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PickupHazzard : MonoBehaviour {
    public GameManager gameManager;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hazzard")
        {
            // Vector3 scale = transform.localScale * 1.3f;
            // transform.localScale = scale;
            // gameManager.AddPoints(-10);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
