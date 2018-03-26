using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour {

	public Vector2 Velocity;

	void FixedUpdate () {
		
		transform.position += (Vector3)Velocity * Time.fixedDeltaTime;
	}
}
