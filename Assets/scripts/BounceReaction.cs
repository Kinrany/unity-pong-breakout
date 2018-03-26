using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BounceReaction : MonoBehaviour {

	public BounceReaction() : base() {
		Bounced = new UnityEvent();
	}

	public void AddListener(UnityAction listener) {
		Bounced.AddListener(listener);
	}

	public void Invoke() {
		Bounced.Invoke();
	}

	UnityEvent Bounced;
}