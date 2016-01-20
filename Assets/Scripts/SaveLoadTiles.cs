using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SaveLoadTiles : MonoBehaviour 
{
	// These are all of the tiles we want to save and load.
	public GameObject[] tiles;
	public GameObject[] labels;
    public GameObject[] smallLabels;

    private int numTiles;
	private int numLabels;
    private int numSmallLabels;

    public GameObject blankTool;
	public GameObject blankLabel;
    public GameObject blankSmallLabel;

    // Save the tiles when the level is changed or application is quit.

    void OnApplicationQuit()
	{
        
        //****************************** get the amount of tiles to be saved/loaded **********************************
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

		//*************************** get the amount of labels to be saved/loaded **********************************
		labels = GameObject.FindGameObjectsWithTag ("Kit_Label");
		numLabels = labels.Length;
		//saving the number of labels 
		ES2.Save(labels.Length, "myOtherFile.txt?tag=labelLength");
		
		// Loop over each of the Labels ...
		for(int i=0; i<labels.Length; i++)
		{
						
			ES2.Save (labels[i].transform.position, "myOtherFile.txt?tag=position"+i);
			
			TextMesh textMesh = labels[i].GetComponentInChildren<TextMesh>();
			ES2.Save(textMesh.text, "myOtherFile.txt?tag=text"+i);
			
		}
       
        //*************************** get the amount of small labels to be saved/loaded **********************************
        smallLabels = GameObject.FindGameObjectsWithTag("Small_Kit_Label");
        numSmallLabels = smallLabels.Length;
        //saving the number of labels 
        ES2.Save(smallLabels.Length, "myOtherSmallFile.txt?tag=smallLabelLength");

        // Loop over each of the Labels ...
        for (int i = 0; i < smallLabels.Length; i++)
        {
            ES2.Save(smallLabels[i].transform.position, "myOtherSmallFile.txt?tag=position" + i);

            TextMesh textMesh = smallLabels[i].GetComponentInChildren<TextMesh>();
            ES2.Save(textMesh.text, "myOtherSmallFile.txt?tag=text" + i);
        }

    }
	
	// Load the tiles when this script starts up.
	void Start() 
	{
		//get number of tiles to load so that i has a value?
		numTiles = ES2.Load<int>("myFile.txt?tag=tileLength");
		numLabels = ES2.Load<int>("myOtherFile.txt?tag=labelLength");
        numSmallLabels = ES2.Load<int>("myOtherSmallFile.txt?tag=smallLabelLength");
        //Debug.Log ("number of tiles loaded is " + numTiles);
        // Loop over each of the tiles we want to load ...
        for (int i=0; i<numTiles; i++)
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
			
			// Get the TextMesh so we can load data into it.
			toolInstance.GetComponentInChildren<TextMesh>().text =  ES2.Load<string>("myFile.txt?tag=text"+i);
			// and change the name of each component to match its on screen text name.
			toolInstance.name = toolInstance.GetComponentInChildren<TextMesh>().text;
			//or give it a number associated with the save file.
	
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
			
			// Get the TextMesh so we can load data into it...
			LabelInstance.GetComponentInChildren<TextMesh>().text =  ES2.Load<string>("myOtherFile.txt?tag=text"+i);

			// and change the name of each component to match its on screen text name.
			LabelInstance.name = "Label " + LabelInstance.GetComponentInChildren<TextMesh>().text;
		}

        for (int i = 0; i < numSmallLabels; i++)
        {
            if (!ES2.Exists("myOtherSmallFile.txt"))
            {
                return;
            }
            //create a blank tool at the location [i] that was saved
            GameObject SmallLabelInstance;
            SmallLabelInstance = Instantiate(blankSmallLabel, ES2.Load<Vector3>("myOtherSmallFile.txt?tag=position" + i), Quaternion.identity) as GameObject;
            // Now load the data using the same filename and tag we used to save it.
            // Get the TextMesh so we can load data into it...
            SmallLabelInstance.GetComponentInChildren<TextMesh>().text = ES2.Load<string>("myOtherSmallFile.txt?tag=text" + i);
            // and change the name of each component to match its on screen text name.
            SmallLabelInstance.name = "Label " + SmallLabelInstance.GetComponentInChildren<TextMesh>().text;
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

        //*************************** get the amount of small labels to be saved/loaded **********************************
        smallLabels = GameObject.FindGameObjectsWithTag("Small_Kit_Label");
        numSmallLabels = smallLabels.Length;
        //saving the number of labels 
        ES2.Save(smallLabels.Length, "myOtherSmallFile.txt?tag=smallLabelLength");

        // Loop over each of the Labels ...
        for (int i = 0; i < smallLabels.Length; i++)
        {

            ES2.Save(smallLabels[i].transform.position, "myOtherSmallFile.txt?tag=position" + i);

            TextMesh textMesh = smallLabels[i].GetComponentInChildren<TextMesh>();
            ES2.Save(textMesh.text, "myOtherSmallFile.txt?tag=text" + i);

        }

    }

    
}
