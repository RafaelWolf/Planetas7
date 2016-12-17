using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ControlBlue : MonoBehaviour {


	public Text countText;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("FireControl")) {
			transform.Rotate (transform.rotation.eulerAngles + new Vector3 (0f, 0.5f, 0f));
		
		}
		if (Input.GetButtonDown ("A")) {
			transform.Rotate (transform.rotation.eulerAngles + new Vector3 (0f, 0.5f, 0f));

		}
		if (Input.GetButtonDown ("B")) {
			transform.Rotate (transform.rotation.eulerAngles + new Vector3 (0f, 0.5f, 0f));

		}
		if (Input.GetButtonDown ("C")) {
			transform.Rotate (transform.rotation.eulerAngles + new Vector3 (0f, 0.5f, 0f));

		}
		if (Input.GetButtonDown ("D")) {
			transform.Rotate (transform.rotation.eulerAngles + new Vector3 (0f, 0.5f, 0f));

		}
		float h = Input.GetAxis ("HorizontalJoy");
		float v = Input.GetAxis ("VerticalJoy");
	
		transform.position += new Vector3 (h*0.5f,v*0.5f,0f);
		print ("Mensaje");
		print ("vertical"+v);
		print ("horizontal"+h);
		//countText.text = Input.GetJoystickNames ();
		countText.text = Input.compositionString;
		countText.text = Input.inputString;

	}
}
