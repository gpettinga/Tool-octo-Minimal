using UnityEngine;
using System.Collections;

public class SpawnHundredsOfObjects : MonoBehaviour 
{
	public Vector3 cameraPosition;
	public int numObjectsToSpawn = 100;
	public float sizeToSpawn = 1.0f;
	public Vector3 SpawnRelToCamera;
	public GameObject spawnableObject;



	public void SpawnManyObjects()
	{
		for (int i=0; i<numObjectsToSpawn; i++) 
		{
			cameraPosition = Camera.main.transform.position;
			SpawnRelToCamera = new Vector3 (cameraPosition.x - 400, cameraPosition.y +  (i *20) , cameraPosition.z + 30);
			Instantiate (spawnableObject, SpawnRelToCamera, Quaternion.identity);
		}
	}

}
