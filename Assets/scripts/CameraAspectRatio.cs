using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAspectRatio : MonoBehaviour {

	public float AspectRatio;

	void Awake() {
		var camera = GetComponent<Camera>();
		camera.aspect = AspectRatio;
	}
}
