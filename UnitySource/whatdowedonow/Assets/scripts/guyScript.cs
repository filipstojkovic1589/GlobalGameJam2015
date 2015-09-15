using UnityEngine;
using System.Collections;

public class guyScript : MonoBehaviour {

	private bool haveMetalHinge = false;


	public girlScript girl;

	public gameManager manager;

	bool[] possibleActions = new bool[10];

	bool talkingPhone = false;
	bool fighting = false;

	public fadeOutScript fade;

	private bool gameOn = true;

	public float walkSpeed = 1;
	private bool _isGrounded = true;

	Animator animator;

	bool _isPlaying_walk = false;

	const int STATE_IDLE = 0;
	const int STATE_WALK = 1;
	const int STATE_JUMP = 2;
	const int STATE_PHONE = 3;
	const int STATE_FIGHT = 4;

	string _currentDirection = "right";
	int _currentAnimationState = STATE_IDLE;

	public bool getGameOn()
	{
		return gameOn;
		}

	void Start () {
		animator = this.GetComponent<Animator> ();

		possibleActions[0] = false; //moguca interakcija sa konzolom
		possibleActions[1] = false; // moguce interakcija sa telefonom
		possibleActions[2] = false; // moguca interakcija sa devojkkom
		possibleActions[3] = false; // moguca interakcija sa vratima lifta
	}

	public void setGameOn(bool onoff){
		gameOn = onoff;
	}

	void FixedUpdate(){
		if (gameOn) {
			Updator ();		
			updateActions();
		}
	}

	// Update is called once per frame
	void Updator () {


		if (Input.GetKey ("right")) {
			talkingPhone = false;
			fighting = false;
			manager.setMsgOff(6);
			manager.setMsgOff(15);


			manager.setMsgOff(16);
			manager.setMsgOff(17);
			manager.setMsgOff(18);


			if(_isGrounded){
						changeDirection ("right");
						transform.Translate (Vector3.right * walkSpeed * Time.deltaTime);
						changeState (STATE_WALK);
			}
				} 

		else if (Input.GetKey ("left")) {
			talkingPhone = false;
			fighting = false;
			manager.setMsgOff(6);
			manager.setMsgOff(15);

			manager.setMsgOff(16);
			manager.setMsgOff(17);
			manager.setMsgOff(18);

			if(_isGrounded){
			changeDirection("left");
			transform.Translate(Vector3.right * walkSpeed * Time.deltaTime);
			changeState(STATE_WALK);
			}
		}
		else if (Input.GetKey ("z")) {
			if(_isGrounded && _currentAnimationState == STATE_IDLE){
				talkingPhone = false;
				fighting = false;
				manager.setMsgOff(6);
				manager.setMsgOff(15);
				_isGrounded = false;
				rigidbody2D.AddForce(new Vector2(0, 250));
				changeState (STATE_JUMP);
			}
		}


		else {
			if(_isGrounded && !talkingPhone && !fighting)
			changeState(STATE_IDLE);
				}

		if (animator.GetCurrentAnimatorStateInfo (0).IsName ("guyWalk"))
						_isPlaying_walk = true;
				else
						_isPlaying_walk = false;
	}

	void changeState(int state){
		if (_currentAnimationState == state) {
			return;		
		}

		switch (state) {
		case STATE_WALK:
			animator.SetInteger("state", STATE_WALK);
			break;

		case STATE_IDLE:
			animator.SetInteger("state", STATE_IDLE);
			break;

		case STATE_JUMP:
			animator.SetInteger("state", STATE_JUMP);
			break;
		case STATE_PHONE:
			animator.SetInteger("state", STATE_PHONE);
			break;
		case STATE_FIGHT:
			animator.SetInteger("state", STATE_FIGHT);
			break;
		}

		_currentAnimationState = state;
	}

	void changeDirection(string direction){
		if (_currentDirection != direction) {
			if(direction == "right"){	
				transform.Rotate(0, 180, 0);
				_currentDirection = "right";
			}
			else if(direction == "left")
			{
				transform.Rotate (0, -180, 0);
				_currentDirection = "left";
			}
		}
	}

	void OnTriggerEnter2D(Collider2D coll){
		if (coll.name == "console") {
			transform.FindChild("xButton").GetComponentInChildren<Renderer>().enabled = true;
			possibleActions[0] = true;
		}
		if (coll.name == "hinge") {
			transform.FindChild("xButton").GetComponentInChildren<Renderer>().enabled = true;	
			possibleActions[1] = true;
		}
		if (coll.name == "girl") {
			transform.FindChild("xButton").GetComponentInChildren<Renderer>().enabled = true;	
			possibleActions[2] = true;
		}
		if (coll.name == "doors") {
			transform.FindChild("xButton").GetComponentInChildren<Renderer>().enabled = true;	
			possibleActions[3] = true;	
		}
	}

	void OnCollisionEnter2D(Collision2D coll){
		if (!_isGrounded) {
						_isGrounded = true;
						changeState (STATE_IDLE);
				}
	}

	void OnTriggerExit2D(Collider2D coll){


			transform.FindChild("xButton").GetComponentInChildren<Renderer>().enabled = false;
		possibleActions [0] = false;
		possibleActions [1] = false;
		possibleActions [2] = false;
		possibleActions [3] = false;

		manager.setMsgOff (8);
		manager.setMsgOff (9);
		manager.setMsgOff (10);
		manager.setMsgOff (11);
		manager.setMsgOff (12);
		manager.setMsgOff (13);
	}

	public void setGravity()
	{
		gameObject.rigidbody2D.mass = 15;
		gameObject.rigidbody2D.gravityScale = 1;
	}

	public bool[] getPossibleActions(){
		return possibleActions;
	}

	int noise=0;
	int message = 0;
	int dislike = 0;

	void updateActions(){
		if(Input.GetKey("x")){
			//if(possibleActions[1]){
				//changeState(STATE_PHONE);
				//talkingPhone = true;
				//manager.setMsgOn(6);
			//}
			if(possibleActions[3]){
				if(!haveMetalHinge){
					manager.setMsgOn(10);
				}else{
					manager.setMsgOn(11);
				}
			}

			if(possibleActions[1]){
				manager.setMsgOn(9);
				haveMetalHinge = true;
			}

			if(possibleActions[0]){
				manager.setMsgOn(8);
			}
		}

	
		if (Input.GetKey ("x")) {
			if(!possibleActions[0] && 	!possibleActions[1] && !possibleActions[2] && !possibleActions[3]){	
				
				manager.setMsgOn(15);
			}
		}


		if (manager.getMsg11()) {
			//int x=Random.Range(1, 3);
			if(Input.GetKey("1")){		
				manager.setMsgOn(12);
				manager.setMsgOff(11);
			}
			if(Input.GetKey("2")){		
				manager.setMsgOn(13);
				manager.setMsgOff(11);
			}
		}

		if (manager.getMsg15 ()) {
			if(Input.GetKey("1")){		
				noise++;
				manager.setMsgOff(15);
				manager.setMsgOn(16);
			}
			if(Input.GetKey("2")){		
				message++;
				manager.setMsgOff(15);
				manager.setMsgOn(17);
			}
			if(Input.GetKey("3")){		
				dislike++;
				manager.setMsgOff(15);
				manager.setMsgOn(18);
			}
		}


	
		if (Input.GetKey ("x")) {
						if (possibleActions [2]) {
				girl.changeState(1);
								changeState (STATE_FIGHT);
								fighting = true;

						}	
				} else {
			if(possibleActions[2]){
				//changeState(STATE_IDLE);
				//fighting = false;
				//girl.changeState(STATE_IDLE);
			}		
		}
	}

	public void switchTalkingPhone(){
		talkingPhone = false;
	}
}
