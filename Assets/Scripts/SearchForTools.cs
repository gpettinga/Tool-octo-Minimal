using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class SearchForTools : MonoBehaviour {

	// Use this for initialization

	public InputField inField;
	public string inFieldText;
	public GameObject toolSearchedFor;
	public Canvas toolOptions;
	public GameObject indicator;

	void Update()
	{

		inFieldText = inField.text.ToString();

	}

	public void Search()
	{

		toolSearchedFor = GameObject.Find (inFieldText);
		if(toolSearchedFor != null)
		{
			toolOptions = toolSearchedFor.GetComponentInChildren<Canvas>();

			Instantiate (indicator, toolSearchedFor.transform.position, Quaternion.identity);

			//toolOptions.enabled = true;
		}

	}
}
