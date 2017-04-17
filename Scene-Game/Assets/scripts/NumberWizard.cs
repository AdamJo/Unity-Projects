using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
	int max;
	int min;
	int guess;

	// Use this for initialization
	void Start () {
		StartGame ();
	}

	void StartGame()
	{
		max = 1000;
		min = 1;
		guess = 500;
		max = max + 1;
		print("=======================");
		print("welcom eto mine games");
		print("Pick a number in your head, but don't tell me");

		print("the highest number you can pick is " + max);
		print("the lowest number you can pick is " + min);

		print ("is the number lower or higher than " + guess);
		print ("up arrow higher, down for lower, return for equal");
	}

	void NextGuess ()
	{
		guess = (max+min) / 2;
			print("Higher or Lower than " + guess);
	}

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			// print ("key was up");
			min = guess;
			NextGuess();
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			max = guess;
			NextGuess();
		}
		if (Input.GetKeyDown (KeyCode.Return)) {
			print ("WoN!");
			StartGame();
		}
	}
}
