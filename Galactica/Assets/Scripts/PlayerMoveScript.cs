﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveScript : MonoBehaviour {

    public float distance;

    public float playerYPos;

    public float min;

    public float max;

    Transform player;

    private Vector2 playerPos;

    bool hasShield = true;

    public GameObject shield;

	// Use this for initialization
	void Start () {

        player = GetComponent<Transform>();

        playerPos = new Vector2(0, playerYPos);
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            //move player right
            playerPos = new Vector2(player.position.x, playerYPos);

            playerPos.x = playerPos.x + (distance * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            //move player left
            playerPos = new Vector2(player.position.x, playerYPos);

            playerPos.x = playerPos.x - (distance * Time.deltaTime);
        }

        playerPos.x = Mathf.Clamp(playerPos.x, min, max);

        this.transform.position = playerPos;



        //FOR SHIELD START  

        if (Input.GetKeyDown(KeyCode.LeftShift) && hasShield == true)
        {
            shield.gameObject.SetActive(true);
            hasShield = false;
        }
	}
}
