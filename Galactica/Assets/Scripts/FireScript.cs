using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScript : MonoBehaviour {

    public GameObject bulletPrefab;
    public GameObject bulletPrefab2;
    public GameObject bulletPrefab3;

    public float projectileVelocity;

    private Transform playerPos;

    private Vector3 spawnLoc;

    audioManager Audio;

    Vector3 offset;


    private void Awake()
    {
        Audio = FindObjectOfType<audioManager>();

    }

    void Update () {

        playerPos = GetComponent<Transform>();
        spawnLoc = new Vector3(playerPos.position.x, playerPos.position.y, playerPos.position.z);

        if (Input.GetButtonDown("Jump"))
        {
            //fires projectile from player

            
            GameObject bullet1 = Instantiate(bulletPrefab, spawnLoc, Quaternion.identity);
            bullet1.GetComponent<Rigidbody2D>().velocity = bullet1.transform.up * projectileVelocity;

            //play sound
            Audio.Play("Laser");





        }
		
	}
}
