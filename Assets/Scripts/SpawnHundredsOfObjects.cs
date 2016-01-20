using UnityEngine;
using System.Collections;

public class SpawnHundredsOfObjects : MonoBehaviour 
{
	public Vector3 cameraPosition;
	public int numObjectsToSpawn;
	public float sizeToSpawn = 1.0f;
	public Vector3 SpawnRelToCamera;
	public GameObject spawnableObject;



	public void SpawnManyObjects()
	{
		for (int x=0; x<numObjectsToSpawn; x++) 
		{
            for (int y = 0; y < numObjectsToSpawn; y++)
            {
                cameraPosition = Camera.main.transform.position;
                Instantiate(spawnableObject, new Vector3(cameraPosition.x + (x + 20) - 400, cameraPosition.y + (y + 20), cameraPosition.z + 30), Quaternion.identity);
            }
        }
	}

}
