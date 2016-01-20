using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeKitText : MonoBehaviour 
{
	public BoxCollider2D thisCollider;

	public GameObject inputField;
	public bool inputOpen;
	// Use this for initialization
	void Start () 
	{
		thisCollider = gameObject.GetComponent<BoxCollider2D> ();
		thisCollider.enabled = false;
		//inputField.SetActive (false);
	}
	
	public void OpenInput()
	{
		//Debug.Log ("Open Text Editor");
		inputField.SetActive (true);
		thisCollider.enabled = true;
	}
	public void CloseInput()
	{
		//Debug.Log("Close Text Editor");
		inputField.SetActive (false);
		thisCollider.enabled = false;
	}
    public void DeleteKit()
    {
        Destroy(gameObject);
    }

}
