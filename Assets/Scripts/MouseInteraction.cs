using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof (Rigidbody2D))]

public class MouseInteraction : MonoBehaviour 
{
	//public bool selected = false;************************************

	float x;
	float y;


	void Start()
	{
		gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
	}


	// Update is called once per frame
	void Update()
	{
		x = Input.mousePosition.x;
		y = Input.mousePosition.y;
		//unused code for selection box ***********************************************
//		if (GetComponent<Renderer>().isVisible && Input.GetMouseButtonUp(0))
//		{
//			Vector3 camPos = Camera.main.WorldToScreenPoint(transform.position);
//			camPos.y = MouseDragSelect.InvertMouseY(camPos.y);
//			selected = MouseDragSelect.selection.Contains(camPos);
//			Debug.Log (selected);
//		}
//		if (selected) 
//		{
//			isSelected = true;
//		}******************************************************************************

	}

	
	void OnMouseDrag()
	{
		gameObject.GetComponent<Rigidbody2D> ().isKinematic = false;
		transform.position = Camera.main.ScreenToWorldPoint (new Vector3 (x, y, 10));
	}

	void OnMouseUp()
	{
		gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
	}
}