using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {

    public float speed = 8;
    Vector3 targetPos;
    Vector3 playerPos;
    GameObject ballObj;


	void Start ()
    {
        ballObj = GameObject.FindGameObjectWithTag("ball");
		
	}

    void Update ()
    {
        targetPos = Vector3.Lerp (gameObject.transform.position, ballObj.transform.position, Time.deltaTime * speed);
        playerPos = new Vector3(-20, Mathf.Clamp(targetPos.y, -12.5F, 12.5F), 0);
        gameObject.transform.position = new Vector3(20, playerPos.y, 0);
    }
}
