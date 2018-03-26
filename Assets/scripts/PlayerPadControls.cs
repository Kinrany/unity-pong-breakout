using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPadControls : MonoBehaviour {

	public float Speed = 1;

	public PlayerId Player;

	public float AttractionStrength;
	public BallMovement Ball;

	void FixedUpdate() {

		float movement = Speed * Time.fixedDeltaTime;

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

		if (inputMoveUp > 0) {
			transform.position += movement * Vector3.up;
		} else if (inputMoveUp < 0) {
			transform.position += movement * Vector3.down;
		}

		Vector2 ballDirection = (transform.position - Ball.transform.position).normalized;
		Vector2 attraction = AttractionStrength * ballDirection * Time.fixedDeltaTime;
		if (inputAttract > 0) {
			Ball.Velocity += attraction;
		} else if (inputAttract < 0) {
			Ball.Velocity += -attraction;
		}
	}

	public enum PlayerId {
		None,
		First,
		Second
	}
}