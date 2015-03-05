using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class SaveTools : MonoBehaviour 
{
	public GameObject[] CBGtoolObjects;

	public int counterInt;
	public string counterIntString;
	public Text toolNumberText;

	void Update () 
	{
		counterInt = GameObject.FindGameObjectsWithTag("CBG_Tool").Length;
		counterIntString = counterInt.ToString();
		toolNumberText.text = counterIntString;
		CBGtoolObjects = GameObject.FindGameObjectsWithTag("CBG_Tool");

	}

	public void saveTools()
		{
			ES2.Save(CBGtoolObjects.Length,"C:/Users/Field_0001/Desktop/Test_Save_Folder/allTools.txt?tag=toolObjectLength");
			Debug.Log ("length of list is"+CBGtoolObjects.Length);
			
		}
		

	public void LoadTools()
	{

			
	}	


}
