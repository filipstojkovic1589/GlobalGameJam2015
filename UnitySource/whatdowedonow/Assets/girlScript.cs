using UnityEngine;
using System.Collections;

public class girlScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	int _currentAnimationState = STATE_IDLE;
	public Animator animator;

	const int STATE_IDLE = 0;
	const int STATE_FIGHT = 1;

	public void changeState(int state){
		if (_currentAnimationState == state) {
			return;		
		}
		
		switch (state) {
		case STATE_IDLE:
			animator.SetInteger("state", STATE_IDLE);
			break;
		case STATE_FIGHT:
			animator.SetInteger("state", STATE_FIGHT);
			break;
		}
		
		_currentAnimationState = state;
	}
}
