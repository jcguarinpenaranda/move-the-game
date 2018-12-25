using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowBallController : MonoBehaviour {
    public Transform target;
    public bool follow = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (follow)
        {
            Vector3 newPos = new Vector3(target.position.x, transform.position.y, target.position.z);
            transform.position = newPos;
        }
    }
}
