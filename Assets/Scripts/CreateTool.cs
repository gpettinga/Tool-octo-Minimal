using UnityEngine;
using System.Collections;

public class CreateTool : MonoBehaviour {

	public GameObject ToolIcon;

	public Vector2 randSpawnPoint;
	public float xpos = 0.0f;
	public float ypos = 0.0f;


	public void SpawnTool(Object ToolIcon)
	{
		randSpawnPoint = Random.insideUnitCircle * 400;
		Instantiate (ToolIcon,randSpawnPoint, Quaternion.identity);
		//Instantiate (ToolIcon, new Vector2(xpos,ypos), Quaternion.identity);


		//Debug.Log ("Tool Spawned");
	
	}
}
