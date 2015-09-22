using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof (Rigidbody2D))]

public class MouseInteraction : MonoBehaviour 
{
	//public bool selected = false;************************************

	float x;
	float y;

	public Vector3 currentPos;

	private BoxCollider2D[] collidersOnTool;


	void Start()
	{
		gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
		//collidersOnTool = gameObject.GetComponents<BoxCollider2D>();
		//gameObject.GetComponent<Collider2D> ().isTrigger = true;
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
		//gameObject.GetComponent<Collider2D> ().isTrigger = false;
		transform.position = Camera.main.ScreenToWorldPoint (new Vector3 (x, y, 10));
		this.gameObject.transform.parent = null;

		currentPos = transform.position;
//		foreach(BoxCollider2D col in collidersOnTool)
//		{
//			col.enabled = false;
//		}
		//Debug.Log (transform.parent);
	}

	void OnMouseUp()
	{
		gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
		transform.position = new Vector3 (currentPos.x, currentPos.y, 0.0f);
//		foreach(BoxCollider2D col in collidersOnTool)
//		{
//			col.enabled = true;
//		}
		//gameObject.GetComponent<Collider2D> ().isTrigger = true;
	}
}