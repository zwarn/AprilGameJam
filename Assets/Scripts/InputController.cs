using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InputController : MonoBehaviour {

	public static InputController Instance;

	private List<Player> players;


	void Awake() {
		if (Instance == null) {
			Instance = this;
		} else {
			Debug.LogError ("InputController already present!!!");
			Destroy (this);
		}
		players = new List<Player> ();
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i < players.Count; i++) {
			checkInput (players [i], i);
		}
	}

	private void checkInput (Player player, int playerNumber) {
		Vector2 movement = new Vector2 (0, 0);
		movement.x = Input.GetAxis ("horizontal" + playerNumber);
		movement.y = Input.GetAxis ("vertical" + playerNumber);
		//movement.Normalize();
		player.setMovement (movement);
	}

	public void registerPlayer (Player player) {
		Debug.Log ("register Player");
		players.Add (player);
	}
}
