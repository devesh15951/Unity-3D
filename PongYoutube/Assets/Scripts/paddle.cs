using UnityEngine;
using System.Collections;

public class paddle : MonoBehaviour {

    public float paddleSpeed = 1F;
    public Vector3 playerPos = new Vector3(0, 0, 0);

	void Update ()
    {
        float yPos = gameObject.transform.position.y + (Input.GetAxis ("Vertical") * paddleSpeed);
        playerPos = new Vector3 (-20,Mathf.Clamp(yPos, -12.5F, 12.5F), 0);
        gameObject.transform.position = playerPos;
	}
}
