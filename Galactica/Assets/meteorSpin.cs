using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorSpin : MonoBehaviour {

    Rigidbody2D meteor;

    int speed;

    int dir;

	// Use this for initialization
	void Start () {
        meteor = GetComponent<Rigidbody2D>();
        dir = Random.Range(1, 3);
        speed = Random.Range(30, 100);
	}
	
	// Update is called once per frame
	void Update () {

        if (dir == 1)
        {
            meteor.transform.Rotate(Vector3.forward, speed * Time.deltaTime);
        }
        else
        {
            meteor.transform.Rotate(Vector3.forward, -speed * Time.deltaTime);
        }

         
		
	}
}
