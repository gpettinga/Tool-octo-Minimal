using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class SimpleCounter : MonoBehaviour 
{

	public int counterInt;
	public string counterIntString;
	public Text toolNumberText;

	void Start()
	{

	}



	void Update () 
	{
		counterInt = GameObject.FindGameObjectsWithTag("Tool").Length;

		counterIntString = counterInt.ToString();
		toolNumberText.text = counterIntString;

	}
}
