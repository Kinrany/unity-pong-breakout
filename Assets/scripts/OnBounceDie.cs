using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnBounceDie : MonoBehaviour {

	void Start() {
		var bounceReaction = GetComponent<BounceReaction>();
		bounceReaction.AddListener(Die);
	}

	void Die() {
		Destroy(gameObject);
	}
}