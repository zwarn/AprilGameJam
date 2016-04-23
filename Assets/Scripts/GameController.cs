using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour {

	public List<GameObject> playerObjects;
	private InputController inputController;

	// Use this for initialization
	void Start () {
		inputController = InputController.Instance;
		foreach (GameObject playerObject in playerObjects) {
			Player player = playerObject.GetComponent<Player> ();
			if (player != null) {
				inputController.registerPlayer (player);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
