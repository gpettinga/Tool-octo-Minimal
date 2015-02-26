using UnityEngine;
using System.Collections;

public class CreateTool : MonoBehaviour {

	public GameObject ToolIcon;
	public float xpos = 0.0f;
	public float ypos = 0.0f;


	public void SpawnTool(Object ToolIcon)
	{
		//Debug.Log ("spawn tool");
		Instantiate (ToolIcon, new Vector2(xpos,ypos), Quaternion.identity);


		//Debug.Log ("Tool Spawned");
	
	}
}
