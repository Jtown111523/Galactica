using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour {
    private Rigidbody2D RIGIDBODY;

    public float scrollSpeed;

    private bool stopScrolling;

	// Use this for initialization
	void Start () {
        RIGIDBODY = GetComponent<Rigidbody2D>();

        RIGIDBODY.velocity = new Vector2(0, -scrollSpeed);
    }
	
	// Update is called once per frame
	void Update () {

        if (stopScrolling)
        {
            RIGIDBODY.velocity = Vector2.zero;
        }
        else
        {
            RIGIDBODY.velocity = new Vector2(0, -scrollSpeed);
        }
		
	}
}
