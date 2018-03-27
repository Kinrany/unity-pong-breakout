using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBouncing : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D collision) {

		var movement = GetComponent<BallMovement>();

		var contact = collision.contacts[0];
		var n = contact.normal;
		var v = movement.Velocity;
		movement.Velocity = Vector2.Reflect(v, n);

		var bounceReaction = collision.gameObject.GetComponent<BounceReaction>();
		if (bounceReaction) {
			bounceReaction.Invoke();
		}
	}
}