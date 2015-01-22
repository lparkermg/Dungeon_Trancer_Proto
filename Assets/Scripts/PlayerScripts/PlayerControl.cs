using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	private float speed = 0.5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxis ("Vertical") > 0)
		{
			MovePlayer ();
		}
	}

	void FixedUpdate(){

	}

	void MovePlayer(){
		rigidbody.AddForce (Vector3.forward * speed * Time.deltaTime,ForceMode.Acceleration);
	}

	void RotatePlayer(){

	}
}
