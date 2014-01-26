using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void FixedUpdate() {
		if(Input.GetKey(KeyCode.A))
			transform.position += new Vector3 (0, 0.05f, 0);
	}
}
