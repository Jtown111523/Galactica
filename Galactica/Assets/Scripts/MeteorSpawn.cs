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

    public GameObject redMeteorPrefab;

    GameObject meteor;
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;

        if(timer<= 0)
        {
            int i = Random.Range(0, 20);
            Debug.Log(i);
            if (i != 1)
            {
                meteor = Instantiate(meteorPrefab, new Vector3(Random.Range(MinX, MaxX), YVal, 0), Quaternion.identity);
                meteor.GetComponent<Rigidbody2D>().velocity = Vector3.down * meteorVelocity;
                //timeChanger = timeChanger + change;
                timer = timeToNextSpawn;
                //Debug.Log(timer);
            }

            if(i == 1)
            {
                //spawn red Meteor
                meteor = Instantiate(redMeteorPrefab, new Vector3(Random.Range(MinX, MaxX), YVal, 0), Quaternion.identity);
                meteor.GetComponent<Rigidbody2D>().velocity = Vector3.down * meteorVelocity;
                //timeChanger = timeChanger + change;
                timer = timeToNextSpawn;
                //Debug.Log(timer);
            }
        }
		
	}
}
