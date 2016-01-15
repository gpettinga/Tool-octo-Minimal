using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SaveLoadTiles : MonoBehaviour 
{
	// These are all of the tiles we want to save and load.
	public GameObject[] tiles;
	public GameObject[] labels;
	private int numTiles;
	private int numLabels;
	public GameObject blankTool;
	public GameObject blankLabel;
    
    // Save the tiles when the level is changed or application is quit.
    
	void OnApplicationQuit()
	{
        
        //get the amount of tiles to be saved/loaded 
        tiles = GameObject.FindGameObjectsWithTag ("Tool");
		numTiles = tiles.Length;
		//saving the number of tiles 
		ES2.Save(tiles.Length, "myFile.txt?tag=tileLength");
		//Debug.Log ("number of tiles saved is " + tiles.Length);
			
		// Loop over each of the tiles ...
		for(int i=0; i<tiles.Length; i++)
		{
			//Debug.Log ("saving tiles?");
			// ... and save each aspect of it, appending it's position to the tag.
			ES2.Save(tiles[i].GetComponentInChildren<Renderer>().material, "myFile.txt?tag=color"+i);
			//Debug.Log (tiles[i].GetComponent<Renderer>().material);

			ES2.Save (tiles[i].transform.position, "myFile.txt?tag=position"+i);
			// Get the TextMesh so we can save it's variables.In children
			TextMesh textMesh = tiles[i].GetComponentInChildren<TextMesh>();
			ES2.Save(textMesh.text, "myFile.txt?tag=text"+i);
			ES2.Save(textMesh.color, "myFile.txt?tag=textColor"+i);
		}

		//get the amount of tiles to be saved/loaded 
		labels = GameObject.FindGameObjectsWithTag ("Kit_Label");
		numLabels = labels.Length;
		//saving the number of tiles 
		ES2.Save(labels.Length, "myOtherFile.txt?tag=labelLength");
		//Debug.Log ("number of tiles saved is " + tiles.Length);
		
		// Loop over each of the Labels ...
		for(int i=0; i<labels.Length; i++)
		{
			//Debug.Log ("saving tiles?");
			// ... and save each aspect of it, appending it's position to the tag.
			//ES2.Save(labels[i].GetComponentInChildren<Renderer>().material, "myFile.txt?tag=color"+i);
			//Debug.Log (tiles[i].GetComponent<Renderer>().material);
			
			ES2.Save (labels[i].transform.position, "myOtherFile.txt?tag=position"+i);
			// Get the TextMesh so we can save it's variables.In children
			TextMesh textMesh = labels[i].GetComponentInChildren<TextMesh>();
			ES2.Save(textMesh.text, "myOtherFile.txt?tag=text"+i);
			//ES2.Save(textMesh.color, "myOtherFile.txt?tag=textColor"+i);
		}
    
	}
	
	// Load the tiles when this script starts up.
	void Start() 
	{
		//get number of tiles to load so that i has a value?
		numTiles = ES2.Load<int>("myFile.txt?tag=tileLength");
		numLabels = ES2.Load<int>("myOtherFile.txt?tag=labelLength");
		//Debug.Log ("number of tiles loaded is " + numTiles);
		// Loop over each of the tiles we want to load ...
		for(int i=0; i<numTiles; i++)
		{
			if (!ES2.Exists("myFile.txt"))
			{
				return;
			}
			//create a blank tool at the location [i] that was saved
			GameObject toolInstance;
			toolInstance = Instantiate(blankTool,ES2.Load<Vector3>("myFile.txt?tag=position"+i),Quaternion.identity) as GameObject;
			// Now load the data using the same filename and tag we used to save it.
			toolInstance.GetComponent<Renderer>().material = ES2.Load<Material>("myFile.txt?tag=color"+i);
			//Debug.Log ("material is "+ES2.Load<Material>("myFile.txt?tag=color"+i) );
			//tiles[i].GetComponent<Renderer>().material = ES2.Load<Material>("myFile.txt?tag=color"+i);
			//we Call this earlier so we dont need it now
			//tiles[i].transform.position = ES2.Load<Vector3>("myFile.txt?tag=position"+i);
			// Get the TextMesh so we can load data into it.
			toolInstance.GetComponentInChildren<TextMesh>().text =  ES2.Load<string>("myFile.txt?tag=text"+i);
			// and change the name of each component to match its on screen text name.
			toolInstance.name = toolInstance.GetComponentInChildren<TextMesh>().text;
			//or give it a number associated with the save file.
			//toolInstance.name = i.ToString();


			//TextMesh textMesh = tiles[i].GetComponentInChildren	<TextMesh>();
			//textMesh.text = ES2.Load<string>("myFile.txt?tag=text"+i);
			toolInstance.GetComponentInChildren<TextMesh>().color = ES2.Load<Color>("myFile.txt?tag=textColor"+i);
		}
		for(int i=0; i<numLabels; i++)
		{
			if (!ES2.Exists("myOtherFile.txt"))
			{
				return;
			}
			//create a blank tool at the location [i] that was saved
			GameObject LabelInstance;
			LabelInstance = Instantiate(blankLabel,ES2.Load<Vector3>("myOtherFile.txt?tag=position"+i),Quaternion.identity) as GameObject;
			// Now load the data using the same filename and tag we used to save it.

			//**********************  Unused for Labels  ********************
			// **toolInstance.GetComponent<Renderer>().material = ES2.Load<Material>("myOtherFile.txt?tag=color"+i);
			// **Debug.Log ("material is "+ES2.Load<Material>("myFile.txt?tag=color"+i) );
			// **tiles[i].GetComponent<Renderer>().material = ES2.Load<Material>("myFile.txt?tag=color"+i);
			// **we Call this earlier so we dont need it now
			// **tiles[i].transform.position = ES2.Load<Vector3>("myFile.txt?tag=position"+i);
			
			// Get the TextMesh so we can load data into it...
			LabelInstance.GetComponentInChildren<TextMesh>().text =  ES2.Load<string>("myOtherFile.txt?tag=text"+i);

			// and change the name of each component to match its on screen text name.
			LabelInstance.name = "Label " + LabelInstance.GetComponentInChildren<TextMesh>().text;
			//TextMesh textMesh = tiles[i].GetComponentInChildren	<TextMesh>();
			//textMesh.text = ES2.Load<string>("myFile.txt?tag=text"+i);
			//LabelInstance.GetComponentInChildren<TextMesh>().color = ES2.Load<Color>("myOtherFile.txt?tag=textColor"+i);
		}
	}
	public void SaveTools()
	{
        
		//get the amount of tiles to be saved/loaded 
		tiles = GameObject.FindGameObjectsWithTag ("Tool");
		numTiles = tiles.Length;
		//saving the number of tiles 
		ES2.Save(tiles.Length, "myFile.txt?tag=tileLength");
		//Debug.Log ("number of tiles saved is " + tiles.Length);
		
		// Loop over each of the tiles ...
		for(int i=0; i<tiles.Length; i++)
		{
			//Debug.Log ("saving tiles?");
			// ... and save each aspect of it, appending it's position to the tag.
			ES2.Save(tiles[i].GetComponentInChildren<Renderer>().material, "myFile.txt?tag=color"+i);
			//Debug.Log (tiles[i].GetComponent<Renderer>().material);
			
			ES2.Save (tiles[i].transform.position, "myFile.txt?tag=position"+i);
			// Get the TextMesh so we can save it's variables.In children
			TextMesh textMesh = tiles[i].GetComponentInChildren<TextMesh>();
			ES2.Save(textMesh.text, "myFile.txt?tag=text"+i);
			ES2.Save(textMesh.color, "myFile.txt?tag=textColor"+i);
		}
		
		//get the amount of tiles to be saved/loaded 
		labels = GameObject.FindGameObjectsWithTag ("Kit_Label");
		numLabels = labels.Length;
		//saving the number of tiles 
		ES2.Save(labels.Length, "myOtherFile.txt?tag=labelLength");
		//Debug.Log ("number of tiles saved is " + tiles.Length);
		
		// Loop over each of the Labels ...
		for(int i=0; i<labels.Length; i++)
		{
			//Debug.Log ("saving tiles?");
			// ... and save each aspect of it, appending it's position to the tag.
			//ES2.Save(labels[i].GetComponentInChildren<Renderer>().material, "myFile.txt?tag=color"+i);
			//Debug.Log (tiles[i].GetComponent<Renderer>().material);
			
			ES2.Save (labels[i].transform.position, "myOtherFile.txt?tag=position"+i);
			// Get the TextMesh so we can save it's variables.In children
			TextMesh textMesh = labels[i].GetComponentInChildren<TextMesh>();
			ES2.Save(textMesh.text, "myOtherFile.txt?tag=text"+i);
			//ES2.Save(textMesh.color, "myOtherFile.txt?tag=textColor"+i);
		}
        
	}

    
}
