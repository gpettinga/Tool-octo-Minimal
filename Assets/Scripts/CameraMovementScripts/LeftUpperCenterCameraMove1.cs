using UnityEngine;
using System.Collections;

public class LeftUpperCenterCameraMove1 : MonoBehaviour 
{

	void OnTriggerEnter2D(Collider2D other)
	{
			if (other.CompareTag ("Tool"))
			{

			if (MoveCamera.camAtPos1 == true)
			{
				MoveCamera.camAtPos1 = false;
				MoveCamera.camAtPosExtra = true;
				MoveCamera.camAtPos3 = false;
				MoveCamera.camAtPos4 = false;
			}
			else if(MoveCamera.camAtPosExtra == true && !MoveCamera.camAtPos1)
			{
				MoveCamera.camAtPos1 = true;
				MoveCamera.camAtPosExtra = false;
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
