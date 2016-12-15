using UnityEngine;
using System.Collections;

public class ControlBlue : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			transform.Rotate (transform.rotation.eulerAngles + new Vector3 (0f, 0.5f, 0f));
			print ("Mensaje");
		}
		float h = Input.GetAxis ("HorizontalJoy");
		float v = Input.GetAxis ("VerticalJoy");
	
		transform.position += new Vector3 (h*0.5f,v*0.5f,0f);
		print ("Mensaje");
		print ("vertical"+v);
		print ("horizontal"+h);
	
	}
}
