using UnityEngine;
using System.Collections;

public class xButtonScript : MonoBehaviour {

	private bool getLarge = false;
	private bool getSmall = false;
	
	void Start() {
		getLarge = true;
	}
	
	void Update() {
		if (transform.localScale.x > 0.13) {
			getSmall = true;
			getLarge = false;
		}

		if (transform.localScale.x < 0.08) {
			getSmall = false;	
			getLarge = true;
		}

		if (getSmall) {
			transform.localScale -= new Vector3 (0.002f, 0.002f, 0.002f);	
		}
		if (getLarge) {
			transform.localScale += new Vector3 (0.002f, 0.002f, 0.002f);		
		}

	}
}
