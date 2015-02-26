using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class SimpleCounter : MonoBehaviour 
{
	public GameObject[] toolObjects;

	public int counterInt;
	public string counterIntString;
	public Text toolNumberText;
	//public Object toolObjects;

	void Start()
	{

	}



	void Update () 
	{
		counterInt = GameObject.FindGameObjectsWithTag("Tool").Length;

		counterIntString = counterInt.ToString();
		toolNumberText.text = counterIntString;
		toolObjects = GameObject.FindGameObjectsWithTag("Tool");

	}

	public void saveTools()
	{
		foreach(GameObject Tool in toolObjects)
		{
			Debug.Log ("Found a Tool "+ Tool.transform.position);
		}
	}
}
