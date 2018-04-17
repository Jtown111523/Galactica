using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour {

    private BoxCollider2D backgroundCollider;

    private float backgroundHeight;

	// Use this for initialization
	void Start () {

        backgroundCollider = GetComponent<BoxCollider2D>();

        backgroundHeight = backgroundCollider.size.y;
		
	}
	
	// Update is called once per frame
	void Update () {

        if(transform.position.y < -backgroundHeight * this.transform.localScale.y)
        {
            backgroundRepeat();
        }
		
	}

    void backgroundRepeat()
    {
        Vector3 BGoffset = new Vector3(0, backgroundHeight * 2 * this.transform.localScale.y, 5);
        transform.position = (Vector3)transform.position + BGoffset;
    }
}
