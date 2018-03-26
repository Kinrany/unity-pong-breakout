using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBouncing : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D collision) {

		var movement = GetComponent<BallMovement>();
		var n = collision.contacts[0].normal;
		var v = movement.Velocity;
		movement.Velocity = Vector2.Reflect(v, n);

		var bounceReaction = collision.gameObject.GetComponent<BounceReaction>();
		if (bounceReaction) {
			bounceReaction.Invoke();
		}
	}
}