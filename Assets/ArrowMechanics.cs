using UnityEngine;
using System.Collections;

public class ArrowMechanics : MonoBehaviour {


	private Vector3 mouseDownPos = Vector3.zero;
	private Vector3 mouseUpPos = Vector3.zero;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		// MOUSE --test

		if(Input.GetMouseButtonDown(0))
			mouseDownPos = Input.mousePosition;
		if(Input.GetMouseButtonUp(0))
			mouseUpPos = Input.mousePosition;

		Debug.Log(mouseDownPos-mouseUpPos);


		// TOUCH --development

		if(Input.touchCount != 1)
			return;
		TouchPhase phase = Input.GetTouch(0).phase;
		if(phase == TouchPhase.Began)
			Debug.Log("TOUCH");
		if(phase == TouchPhase.Ended || phase == TouchPhase.Canceled)
			Debug.Log("RELEASE");
	}
}
