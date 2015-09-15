using UnityEngine;
using System.Collections;

public class gameManager : MonoBehaviour {

	public static bool msg1, msg2, msg3, msg4, msg5, msg6, msg7, msg8, msg9, msg10, msg11, msg12, msg13, msg14, msg15, msg16, msg17, msg18, msg19, msg20, msg21, msg22, msg23, msg24, msg25, msg26 = false;

	public deepestBgScript deepestBg;
	public sideBgScript sideBg;

	public guyScript guy;

	void Start () {
		//msg1 = true;
		StartCoroutine(dialogFlow());
	}

	public void setMsgOn(int x){
		if (x == 6) {
			msg6 = true;		
		}
		if (x == 8) {
			msg8=true;		
		}
		if (x == 9) {
			msg9=true;		
		}
		if (x == 10) {
			msg10=true;		
		}
		if (x == 11) {
			msg11=true;		
		}
		if (x == 12) {
			msg12=true;		
		}
		if (x == 13) {
			msg13=true;		
		}
		if (x == 14) {
			msg14=true;		
		}
		if (x == 15) {
			msg15=true;		
		}
		if (x == 16) {
			msg16=true;		
		}
		if (x == 17) {
			msg17=true;		
		}
		if (x == 18) {
			msg18=true;		
		}

		if (x == 19) {
			msg19=true;		
		}

		if (x == 20) {
			msg20=true;		
		}

		if (x == 21) {
			msg21=true;		
		}

		if (x == 22) {
			msg22=true;		
		}

		if (x == 23) {
			msg23=true;		
		}

		if (x == 24) {
			msg24=true;		
		}

		if (x == 25) {
			msg25=true;		
		}

		if (x == 18) {
			msg18=true;		
		}
	}

	public void setMsgOff(int x){
		if (x == 6) {
			msg8 = false;		
		}
		if (x == 8) {
			msg8=false;		
		}
		if (x == 9) {
			msg9=false;		
		}
		if (x == 10) {
			msg10=false;		
		}
		if (x == 11) {
			msg11=false;		
		}
		if (x == 12) {
			msg12=false;		
		}
		if (x == 13) {
			msg13=false;		
		}
		if (x == 14) {
			msg14=false;		
		}
		if (x == 15) {
			msg15=false;		
		}
		if (x == 16) {
			msg16=false;		
		}
		if (x == 17) {
			msg17=false;		
		}
		if (x == 18) {
			msg18=false;		
		}
		if (x == 19) {
			msg19=false;		
		}
		
		if (x == 20) {
			msg20=false;		
		}
		
		if (x == 21) {
			msg21=false;		
		}
		
		if (x == 22) {
			msg22=false;		
		}
		
		if (x == 23) {
			msg23=false;		
		}
		
		if (x == 24) {
			msg24=false;		
		}
		
		if (x == 25) {
			msg25=false;		
		}
		
		if (x == 18) {
			msg18=false;		
		}
	}


	IEnumerator dialogFlow(){
			
		yield return new WaitForSeconds(4.0f);

		msg1 = true;

			yield return new WaitForSeconds(4.0f);

			msg1 = false;
			msg2 = true;

			deepestBg.stopMovement();
			sideBg.stopMovement();

			yield return new WaitForSeconds(3.0f);

			msg2 = false;
			msg3 = true;

			yield return new WaitForSeconds(3.0f);

			msg3 = false;
			msg4 = true;

			yield return new WaitForSeconds(3.0f);

			msg4 = false;
			msg5 = true;

			yield return new WaitForSeconds(4.0f);

		msg5 = false;
		msg7 = true;

		yield return new WaitForSeconds(3.0f); 

		guy.setGameOn (true);
		msg7 = false;


	}
	

	private bool msg62 =false;

	void OnGUI(){
		if (msg1) {
			naratorSay("You are taking the elevator to the 6th floor...");
		}
		if (msg2) {
			naratorSay("Suddenly you hear some cracking above your head...");
		}
		if (msg3) {
			boySay("Wait, what is this?");	
		}
		if (msg4) {
			girlSay("Oh dear...");	
		}

		if (msg5) {
			boySay("This elevator didn't get stuck, didn't it? We can't get out!");		
		}


		if (msg7) {
			girlSay("What do we do now?");		
		}

		if (msg6) {
			boySay("Hmmm, no wonder there's no signal in elevator...");	
		}

		if (msg8) {
			naratorSay("Pressing any of the buttons doesn't work, You press the help button and hope someone notices your call.");		
		}

		if (msg9) {
			naratorSay("Inspecting the corner of the car you find a loose metal hinge which you pick apart.");		
		}

		if (msg10) {
			naratorSay("You bang on the lift loudly and hope that somebody hears you.");		
		}
		if (msg11) {
			naratorSay("Do you want to:\n1. Bash on the door?\n2. Try to pry open the lift door?");		
		}
		if (msg12) {
			naratorSay("Yeah? Oh well, keep trying...");		
		}
		if (msg13) {
			naratorSay("You succesfully open the lift door and manage to get yourself out.");		
		}
		if (msg14) {
			naratorSay("Unfortunately, you rocked the elevator car like a complete retard and you lead both yourself and the girl to certain death.");		
		}
		if (msg15) {
			naratorSay("1. Yell.\n2. Look at phone.\n3. Cry.");		
		}


		if (msg16) {
			naratorSay("You shout for help and hope people could hear you.");		
		}
		if (msg17) {
			naratorSay("You browse your phone to kill time for several minutes, chatting with people and hoping some of them helps you get out.");		
		}
		if (msg18) {
			naratorSay("You weep like weakling and the girl looks at you with disgust and bewilderment.");		
		}


		if (msg17) {
			naratorSay("1. Flirt.\n2. Casual talk.\n3. Nerdy talk.\n4. Jab.");		
		}

		if (msg18) {
			naratorSay("So, what brings a lovely girl like you here?");		
		}
		if (msg19) {
			naratorSay("The same thing that's gonna bring you out if you coax me like this.");		
		}
		if (msg20) {
			naratorSay("");		
		}
	}

	public bool getMsg11(){
		return msg11;
	}

	public bool getMsg15(){
		return msg15;
	}

	void naratorSay(string text){
		GUI.Label(new Rect(120,635,850,500),"<color=White><size=38>" + text + "</size></color>");	
	}

	void girlSay(string text){
		GUI.Label(new Rect(120,635,850,500),"<color=Red><size=38>Girl: </size></color><color=White><size=38>" + text +"</size></color>");
	}

	void boySay(string text){
		GUI.Label(new Rect(120,635,850,500),"<color=Green><size=38>Boy: </size></color><color=White><size=38>" + text +"</size></color>");
	}



}
