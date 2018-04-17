using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScript : MonoBehaviour {

    public GameObject bulletPrefab;

    public float projectileVelocity;

    private Transform playerPos;

    private Vector3 spawnLoc;

    // Update is called once per frame
    void Update () {

        playerPos = GetComponent<Transform>();
        spawnLoc = new Vector3(playerPos.position.x, playerPos.position.y, playerPos.position.z);

        if (Input.GetButtonDown("Jump"))
        {
            //fires projectile from player

            GameObject bullet = Instantiate(bulletPrefab, spawnLoc, Quaternion.identity);

            bullet.GetComponent<Rigidbody2D>().velocity = bullet.transform.up * projectileVelocity;

        }
		
	}
}
