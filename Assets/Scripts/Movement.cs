using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public Transform swim;
	private float swimSpeed = 3f;

	// Update is called once per frame
	void Update () {
		float move = swimSpeed * Time.deltaTime;
		transform.position = Vector3.forward;
	}
}
