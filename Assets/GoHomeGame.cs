using UnityEngine;
using System.Collections;

public class GoHomeGame : MonoBehaviour {

	int numberOfSteps = 0;

	Vector2 homeLocation = new Vector2 (10, 4);
	Vector2 playerLocation = new Vector2 (2, 8);
	bool gameOver = false;

	// Use this for initialization
	void Start () {
		PrintWelcomeMessage();
	}
	
	// Update is called once per frame
	void Update () {

		if (gameOver) {
			return;
		}

		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			playerLocation = playerLocation + Vector2.down;
			PrintUpdateAndContinue ();
		} else if (Input.GetKeyDown (KeyCode.UpArrow)) {
			playerLocation = playerLocation + Vector2.up;
			PrintUpdateAndContinue ();
		} else if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			playerLocation = playerLocation + Vector2.left;
			PrintUpdateAndContinue ();
		} else if (Input.GetKeyDown (KeyCode.RightArrow)) {
			playerLocation = playerLocation + Vector2.right;
			PrintUpdateAndContinue ();
		}
	}

	/*  FUNCTIONS  */

	void PrintWelcomeMessage () {
		print ("Welcome to Go Home!\nA game where you need to find your way home.\n");
	}

	void PrintUpdateAndContinue () {
		Vector2 distance = homeLocation - playerLocation;
		gameOver = distance.magnitude == 0;

		numberOfSteps++;

		if (gameOver) {
			print ("After " + numberOfSteps + " steps, you have made it home.");
		} else {
			print ("After " + numberOfSteps + " steps, you are " + distance.magnitude + " meters away from home.");
		}
	}
}
