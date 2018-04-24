using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveScript : MonoBehaviour {

    public float distance;

    public float playerYPos;

    public float min;

    public float max;

    Transform player;

    private Vector2 playerPos;

    int shieldCount;

    public GameObject shield;

    [HideInInspector]
    public bool shieldOut = false;

	// Use this for initialization
	void Start () {

        player = GetComponent<Transform>();

        playerPos = new Vector2(0, playerYPos);

        shieldCount = PlayerPrefs.GetInt("ShieldCount");

        shield = (GameObject)Resources.Load("Shield");

        Cursor.lockState = CursorLockMode.Locked;
		
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

        if (Input.GetKeyDown(KeyCode.LeftShift) && shieldCount > 0 && shieldOut == false)
        {
            Instantiate(shield, this.gameObject.transform.position, new Quaternion(0,0,180,0));
            shieldOut = true;
            shieldCount--;
            PlayerPrefs.SetInt("ShieldCount", shieldCount);
        }
	}
}
