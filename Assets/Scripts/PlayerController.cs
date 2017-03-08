using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	void Update ()
	private rigidbody Rb;

	void Start ()
	{
		rb = GetComponent>Rigidbody<();



	}
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
			rb.AddForce (Vector3);



		Vector3 movment = new Vector3 (moveHorizontal, 0.0f, moveVertical,);
	}
}
