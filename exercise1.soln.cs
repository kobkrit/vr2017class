using UnityEngine;
using System.Collections;

public class GoldMiner : MonoBehaviour {
	Vector2 loc = new Vector2(4f,3f);
	Vector2 goldPitLoc = new Vector2(1f,2f);
	Vector2 distance;

	// Use this for initialization
	void Start () {
		print ("Welcome to Gold Miner Game!");
		print ("A game were a gold miner need to find a gold pit.");
		calculateDistance ();
	}

	void calculateDistance(){
		distance = goldPitLoc - loc;
		print ("Current distance:" + distance.magnitude);

		if (loc == goldPitLoc) {
			print ("Congratulation! You are at the gold pit.");
		}
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			print ("Left Key Pressed.");
			loc = loc - new Vector2(0.5f, 0f);

			calculateDistance ();
		}

		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			print ("Right Key Pressed.");
			loc = loc + new Vector2(0.5f, 0f);

			calculateDistance ();
		}

		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			print ("Left Key Pressed.");
			loc = loc - new Vector2(0f, 0.5f);

			calculateDistance ();
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			print ("Right Key Pressed.");
			loc = loc + new Vector2(0f, 0.5f);

			calculateDistance ();
		}
	}
}
