using UnityEngine;
using System.Collections;

public class elevatorScript : MonoBehaviour {

	public gameManager manager;

	public HingeJoint2D hinge;
	public guyScript guy;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("x")) {
			//if(guy.getPossibleActions()[0]){
				//hinge.enabled = false;
				//gameObject.rigidbody2D.gravityScale = 1;
				//guy.setGravity();
			//}
		}
		if (hinge.transform.position.x < -0.23) {
			hinge.enabled = false;
			gameObject.rigidbody2D.gravityScale = 1;
			guy.setGravity();	

			manager.setMsgOn(14);
		}
	}

	void OnTriggerEnter2D(Collider2D coll){
		
	}

}
