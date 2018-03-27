using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour {

	public Vector2 Velocity;
	public float MaxMagnitude;

	void FixedUpdate () {
		Velocity = Vector2.ClampMagnitude(Velocity, MaxMagnitude);
		transform.position += (Vector3)Velocity * Time.fixedDeltaTime;
	}
}
