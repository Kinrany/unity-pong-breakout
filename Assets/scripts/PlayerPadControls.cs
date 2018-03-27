using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPadControls : MonoBehaviour {

	public float Speed = 1;
	public float MinY = float.NegativeInfinity;
	public float MaxY = float.PositiveInfinity;

	public PlayerId Player;

	public float AttractionStrength;
	public BallMovement Ball;

	void FixedUpdate() {

		float dt = Time.fixedDeltaTime;
		Transform t = transform;


		// load input

		float inputMoveUp = 0;
		float inputAttract = 0;

		switch (Player) {
			case PlayerId.First:
				inputMoveUp = Input.GetAxis("1 move up");
				inputAttract = Input.GetAxis("1 attract");
				break;
			case PlayerId.Second:
				inputMoveUp = Input.GetAxis("2 move up");
				inputAttract = Input.GetAxis("2 attract");
				break;
			default:
				throw new InvalidOperationException("Player not specified");
		}


		// move the pad

		float movement = Speed * dt;

		t.position += inputMoveUp * movement * Vector3.up;
		t.position = new Vector2(t.position.x, Mathf.Clamp(t.position.y, MinY, MaxY));


		// attract/repel the ball

		Vector2 pos = t.position;
		Vector2 ballPos = Ball.transform.position;

		Vector2 ballDirection = (pos - ballPos).normalized;
		//float ballDistance = (pos - ballPos).magnitude;

		Vector2 attraction = AttractionStrength * ballDirection * dt;

		Ball.Velocity += inputAttract * attraction;
	}

	public enum PlayerId {
		None,
		First,
		Second
	}
}