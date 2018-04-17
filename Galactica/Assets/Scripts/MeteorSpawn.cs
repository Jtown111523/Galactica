using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawn : MonoBehaviour {
    [HideInInspector]
    public float timer;

    public float timeToNextSpawn;

    public float meteorVelocity;

    public float MinX;

    public float MaxX;

    public float YVal;

    public GameObject meteorPrefab;

    GameObject meteor;
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;

        if(timer<= 0)
        {
            meteor = Instantiate(meteorPrefab, new Vector3(Random.Range(MinX, MaxX), YVal, 0), Quaternion.identity);
            meteor.GetComponent<Rigidbody2D>().velocity = Vector3.down * meteorVelocity;
            timer = timeToNextSpawn;
        }
		
	}
}
