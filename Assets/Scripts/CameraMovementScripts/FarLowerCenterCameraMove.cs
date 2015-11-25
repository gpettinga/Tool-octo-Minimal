using UnityEngine;
using System.Collections;

public class FarLowerCenterCameraMove : MonoBehaviour 
{

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.CompareTag ("Tool"))
		{
			if (MoveCamera.camAtPos4 == true)
			{
				MoveCamera.camAtPos1 = false;
				MoveCamera.camAtPos2 = false;
				MoveCamera.camAtPos3 = false;
				MoveCamera.camAtPos4 = false;
				MoveCamera.camAtPos5 = false;
				MoveCamera.camAtPos6 = true;
			}
			else if(MoveCamera.camAtPos6 == true && !MoveCamera.camAtPos4)
			{
				MoveCamera.camAtPos1 = false;
				MoveCamera.camAtPos2 = false;
				MoveCamera.camAtPos3 = false;
				MoveCamera.camAtPos4 = true;
				MoveCamera.camAtPos5 = false;
				MoveCamera.camAtPos6 = false;
			}

			else 
			{
				return;
			}
		}
	}

}
