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


	void Update () 
	{
		counterInt = GameObject.FindGameObjectsWithTag("Tool").Length;
		counterIntString = counterInt.ToString();
		toolNumberText.text = counterIntString;
		toolObjects = GameObject.FindGameObjectsWithTag("Tool");

	}

	public void saveTools()
		{

			ES2.Save(toolObjects.Length,"C:/Users/Field_0001/Desktop/Test_Save_Folder/allTools.txt?tag=toolObjectLength");

			for (int i = 0; i < toolObjects.Length; i++)
			{
					//SaveIndividualParts(i);
			}

			foreach(GameObject Tool in toolObjects)
			{
				ToolSpecificInformation toolInforScript = Tool.GetComponent<ToolSpecificInformation>();

				ES2.Save(transform.position, "C:/Users/Field_0001/Desktop/Test_Save_Folder/allTools.txt?tag="+toolInforScript.toolNumber);
				ES2.Save (toolInforScript.toolType,"C:/Users/Field_0001/Desktop/Test_Save_Folder/allTools.txt?tag="+toolInforScript.toolType);
				Debug.Log ("Saved Tool Number "+ toolInforScript.toolNumber + Tool.transform.position+ toolInforScript.toolType);
			}
		}
		//Saves all of the tools positions into a single file with the toolObject.lengths, under tag of each tools position
//		public void SaveIndividualParts(int position) //int position
//		{
//			ToolSpecificInformation toolInforScript = GetComponent<ToolSpecificInformation>();
//			placement = toolInforScript.whereIsTool;
//			ES2.Save(position, "C:/Users/Field_0001/Desktop/Test_Save_Folder/allTools.txt?tag="+position);
//			ES2.Save (placement, "C:/Users/Field_0001/Desktop/Test_Save_Folder/allTools.txt?tag=" + position);
//			Debug.Log ("Saved Tool Number "+ position + placement);
//		}

	public void LoadTools()
	{

			int toolObjects = ES2.Load<int>("C:/Users/Field_0001/Desktop/Test_Save_Folder/allTools.txt?tag=toolObjectLength");

//			ToolLocation = ES2.Load<transform.position>
//			//ToolSpecificInformation toolInfoScript = Tool.GetComponent<ToolSpecificInformation>();	

			Debug.Log ("Loaded Number of Tools "+ toolObjects);
			

			for(int i = 0; i < toolObjects; i++ )
				{
					//toolpos = ES2.Load<Vector3>(transform.position,"C:/Users/Field_0001/Desktop/Test_Save_Folder/allTools.txt?tag="+i);
					//Instantiate(toolObjects, toolpos, Quaternion.identity);
					i++;
				}
	}	


}
