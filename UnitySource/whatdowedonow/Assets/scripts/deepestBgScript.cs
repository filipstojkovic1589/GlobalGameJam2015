using UnityEngine;
using System.Collections;

public class deepestBgScript : MonoBehaviour {

	bool moveMe = true;
	bool stopMove = false;

	float speed = 0.85f;
	private float stopingSpeed = 0.007f;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (moveMe) {
			transform.Translate(Vector3.down * speed * Time.deltaTime);
		}
		if (stopMove) {
			if(speed > 0.0f){		
				speed -= stopingSpeed;
			}else{
				stopMove = false;
			}
		}
	}
	
	public void stopMovement(){
		stopMove = true;
	}
}
