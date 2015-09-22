using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CopyTool : MonoBehaviour 
{
	private GameObject thisTool;
	private Vector3 thisPosOffset;

	public void CreateDuplicate()
	{
		thisTool = this.gameObject;
		thisPosOffset = new Vector3 (gameObject.transform.position.x + 1.5f, 0, gameObject.transform.position.z);
		Instantiate (thisTool, thisPosOffset, Quaternion.identity); 

	}

}
