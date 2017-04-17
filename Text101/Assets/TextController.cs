using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, corridor_0};
	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update ()
	{
		//print(myState);
		print (myState);
		if      (myState == States.cell) 		{cell ();} 
		else if (myState == States.sheets_0)	{sheets_0 ();} 
		else if (myState == States.lock_0)		{lock_0 ();} 
		else if (myState == States.lock_1) 		{lock_1 ();} 
		else if (myState == States.mirror) 		{mirror();} 
		else if (myState == States.cell_mirror) {cell_mirror();} 
		else if (myState == States.sheets_1) 	{sheets_1();} 
		else if (myState == States.corridor_0) 	{corridor_0();} 
	}

	void cell ()
	{
		text.text = "You are in your own prison cell created by yourself when first awakening. " +
		"Going deeper into your mind has found no exist and you must escape. " +
		"To do so, stop thinking of the walls as walls just go flow through them to the next area.\n\n" +
		"Press S to view Sheets, M to view Mirror, L to view Lock."; 

		if (Input.GetKeyDown (KeyCode.S)) 		{myState = States.sheets_0;} 
		else if (Input.GetKeyDown (KeyCode.L))  {myState = States.lock_0;}
		else if (Input.GetKeyDown (KeyCode.M))  {myState = States.mirror;}
 	}

	void sheets_0 ()
	{
		text.text = "You can't believe how cold and tired you are from a long rest. " +
					"No idea what time it is you try to slumber back into bed. \n\n" +
					"Press R to return to the middle of the cell.";

		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell;
		}
	}

	void lock_0 ()
	{
		text.text = "A keycode lock statis numbers being flown left to right across it's screen. " +
			"After staring you start to see a pattern...\n\n" +
					"Press R to return to the middle of the cell.";

		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell;
		}
	}

	void mirror ()
	{
		text.text = "Look to your left and the entire wall is a grimey mirror. " +
					"You can barely make our your reflection looking back at you " +
					"Upon close inspection you see a see a crack in the side of one that you can dislodge. \n\n" +
					"Press T to move forward and take the piece, Press R to return to the middle of the cell.";

		if (Input.GetKeyDown (KeyCode.T)) {
			myState = States.cell_mirror;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell;
		}
	}

	void cell_mirror ()
	{
		text.text = "You find a new lock on the other side of the broken piece " +
					"On the other side is a patter that looks to be made by someone. \n\n" +
					"Press L to examine lock, Press S to move towards pattern.";
			
		if (Input.GetKeyDown (KeyCode.L)) {
			myState = States.lock_1;
		} else if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.sheets_1;
		}
	}

	void sheets_1 ()
	{
		text.text = "The pattern seems to be a picture of a teddy gram eating the contents of an old peanut butter jelly can" +
					"On the other side is a patter that looks to be made by someone. \n\n" +
					"Press R to return to cell mirror";

		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell_mirror;
		}
	}

	void lock_1 ()
	{
		text.text = "The lock seems to open by pressing a thumb print on it. \n\n " +
					"Press O to put thumb print on lock, Press R to return to the mirror.";

		if (Input.GetKeyDown (KeyCode.O)) {
			myState = States.corridor_0;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell_mirror;
		}
	}

	void corridor_0 ()
	{
		text.text = "You have found yourself in a corridor. Where to go next?\n\n" + 
					"Press P to play again";

		if (Input.GetKeyDown (KeyCode.P)) {
			myState = States.cell;
		}
	}
}
