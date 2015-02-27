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

		//This Does not work yet, Commenting out for now.GP
//		ES2.Save(toolObjects.Length,"C:/Users/Field_0001/Desktop/Test_Save_Folder/allTools.txt?tag=toolObjectLength");
//
//		for (int i = 0; i < toolObjects.Length; i++)
//		{
//			toolObjects[i].SaveIndividualParts(i);
//		}


//		foreach(GameObject Tool in toolObjects)
//		{
//			ToolSpecificInformation toolInforScript = Tool.GetComponent<ToolSpecificInformation>();
//
//			ES2.Save(transform.position, "C:/Users/Field_0001/Desktop/Test_Save_Folder/toolpos"+toolInforScript.toolNumber+".txt");
//			Debug.Log ("Saved Tool Number "+ toolInforScript.toolNumber + Tool.transform.position);
//		}
	}

	public void SaveIndividualParts(int position)
	{
		//ToolSpecificInformation toolInforScript = GetComponent<ToolSpecificInformation>();
		
		ES2.Save(transform.position, "C:/Users/Field_0001/Desktop/Test_Save_Folder/toolpos.txt?tag="+position);
		//Debug.Log ("Saved Tool Number "+ toolInforScript.toolNumber + transform.position);
	}

	public void LoadTools()
	{
		if (ES2.Exists("C:/Users/Field_0001/Desktop/Test_Save_Folder/toolpos"+1+".txt"))
		    {
//			ToolLocation = ES2.Load<transform.position>
//			//ToolSpecificInformation toolInfoScript = Tool.GetComponent<ToolSpecificInformation>();
//			Debug.Log ("Loaded tool Number ");

			}
	}
}
