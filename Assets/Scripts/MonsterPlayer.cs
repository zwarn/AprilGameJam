using UnityEngine;
using System.Collections;

public class MonsterPlayer : MonoBehaviour, Player {

	Rigidbody2D rigidBody;
	public float speed = 20f;

	// Use this for initialization
	void Start () {
		rigidBody = gameObject.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void setMovement(Vector2 direction) {
		rigidBody.velocity = direction * speed;
	}
}
