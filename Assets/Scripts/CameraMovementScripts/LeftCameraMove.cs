using UnityEngine;
using System.Collections;

public class LeftCameraMove : MonoBehaviour 
{

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag ("Tool"))
		{
			if (MoveCamera.camAtPos1 == true)
			{
				MoveCamera.camAtPos1 = false;
				MoveCamera.camAtPos2 = false;
				MoveCamera.camAtPos3 = true;
				MoveCamera.camAtPos4 = false;
			}
			else if(MoveCamera.camAtPos3 == true && !MoveCamera.camAtPos1)
			{
				MoveCamera.camAtPos1 = true;
				MoveCamera.camAtPos2 = false;
				MoveCamera.camAtPos3 = false;
				MoveCamera.camAtPos4 = false;
			}

			else 
			{
				return;
			}
		}
	}

}
