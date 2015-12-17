using UnityEngine;
using System.Collections;

public class LineUpTools : MonoBehaviour
{

    public float xPos;
    public float yPos;

		
	// Update is called once per frame
	void Update ()
    {

        xPos = gameObject.transform.position.x;
        yPos = gameObject.transform.position.y;

        

	}
}
