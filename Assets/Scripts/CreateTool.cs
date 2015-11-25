using UnityEngine;
using System.Collections;

public class CreateTool : MonoBehaviour {

	public GameObject ToolIcon;

	public Vector3 randSpawnPoint;
	public float xpos = 0.0f;
	public float ypos = 0.0f;
	public Vector3 nonRandSpawn;
	void Start()
	{

	}

	public void SpawnTool(Object ToolIcon)
	{
		//Creates a new tool at the center point of the camera
		//Vector3 randSpawnPoint = Camera.main.ScreenToWorldPoint( new Vector3(Screen.width/2, Screen.height/2, 30));

		//Creates tool at a random point on screen one
		randSpawnPoint = Random.insideUnitCircle * 400;
		Instantiate (ToolIcon,nonRandSpawn, Quaternion.identity);

	}
}
