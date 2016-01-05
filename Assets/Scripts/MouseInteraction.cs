using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof (Rigidbody2D))]

public class MouseInteraction : MonoBehaviour 
{
	//public bool selected = false;************************************
    float x;
	float y;
	float z;

	public Vector3 currentPos;

    public float xPos;
    public float yPos;

    public float xPosRounded;
    public float yPosRounded;

    public Vector2 newPos;

    void Start()
	{
		gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
	}

	// Update is called once per frame
	void Update()
	{
		x = Input.mousePosition.x;
		y = Input.mousePosition.y;
	}

	
	void OnMouseDrag()
	{
		gameObject.GetComponent<Rigidbody2D> ().isKinematic = false;
		transform.position = Camera.main.ScreenToWorldPoint (new Vector3 (x, y, 10));
		this.gameObject.transform.parent = null;

		currentPos = transform.position;
	}

	void OnMouseUp()
	{
		gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
		transform.position = new Vector3 (currentPos.x, currentPos.y, 0.0f);

        xPos = gameObject.transform.position.x;
        yPos = gameObject.transform.position.y;

        xPosRounded = Mathf.Round(xPos / 10) * 10;
        yPosRounded = Mathf.Round(yPos / 10) * 10;

        newPos = new Vector2(xPosRounded, yPosRounded);

        gameObject.transform.position = newPos;
    }
}