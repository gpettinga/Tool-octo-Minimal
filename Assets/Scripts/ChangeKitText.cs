using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeKitText : MonoBehaviour 
{
	public GameObject inputField;

	public bool inputOpen;
	// Use this for initialization
	void Start () 
	{
		//inputField.SetActive (false);
	}
	
	public void OpenInput()
	{
		Debug.Log ("Open Text Editor");
		inputField.SetActive (true);
	}
	public void CloseInput()
	{
		Debug.Log("Close Text Editor");
		inputField.SetActive (false);
	}

}
