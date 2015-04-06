using UnityEngine;
using System.Collections;

[RequireComponent(typeof (Rigidbody2D))]

public class MouseInteraction : MonoBehaviour 
{

	float x;
	float y;


	void Start()
	{
		gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
	}


	// Update is called once per frame
	void Update(){
		x = Input.mousePosition.x;
		y = Input.mousePosition.y;
	}
	
	void OnMouseDrag()
	{
		gameObject.GetComponent<Rigidbody2D>().isKinematic = false;
		transform.position = Camera.main.ScreenToWorldPoint(new Vector3(x,y,10));
	}

	void OnMouseUp()
	{
		gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
	}
}