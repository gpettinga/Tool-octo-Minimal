using UnityEngine;
using System.Collections;

public class RightCameraMove : MonoBehaviour 
{

	void OnTriggerEnter2D(Collider2D other)
	{

		if (MoveCamera.camAtPos2 == true)
		{
			MoveCamera.camAtPos1 = false;
			MoveCamera.camAtPos2 = false;
			MoveCamera.camAtPos3 = false;
			MoveCamera.camAtPos4 = true;
		}
		else if(MoveCamera.camAtPos4 == true && !MoveCamera.camAtPos1)
		{
			MoveCamera.camAtPos1 = false;
			MoveCamera.camAtPos2 = true;
			MoveCamera.camAtPos3 = false;
			MoveCamera.camAtPos4 = false;
		}

		else 
		{
			return;
		}
	}

}
