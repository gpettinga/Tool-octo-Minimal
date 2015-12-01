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
			SpawnRelToCamera = new Vector3 (cameraPosition.x + Random.Range (-100, 100) * sizeToSpawn, cameraPosition.y + Random.Range (-100, 100) * sizeToSpawn, cameraPosition.z + 30);
			Instantiate (spawnableObject, SpawnRelToCamera, Quaternion.identity);
		}
	}

}
