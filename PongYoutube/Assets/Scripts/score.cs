using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

    public TextMesh currSco;
    public GameObject ballPref;
    public Transform paddleObj;

    GameObject ball;
    int score;


    void Update () {
        ball = GameObject.FindGameObjectWithTag("ball");
        currSco.text = "" + score;
        	
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "ball")
        {
            score= score +1;
            Destroy(ball);
            (Instantiate(ballPref, new Vector3(paddleObj.transform.position.x + 2, paddleObj.transform.position.y, 0), Quaternion.identity) as GameObject).transform.parent = paddleObj;
        }
    }
}
