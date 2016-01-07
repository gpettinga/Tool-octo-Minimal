using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeOrDestroyTool : MonoBehaviour {

	public bool mouseOverTool;
	public GameObject toolOptions;
	void Start()
	{
		//toolOptions = GetComponentInChildren<Canvas> ();
		toolOptions.SetActive(false);
	}

	void OnMouseEnter()
	{
		mouseOverTool = true;
	}
    void OnMouseOver()
    {
        mouseOverTool = true;
        if (Input.GetMouseButtonDown(1))
        {
            toolOptions.SetActive(true);
        }
    }

	void OnMouseExit()
	{
		mouseOverTool = false;
	}

	
	public void Open()
	{
        toolOptions.SetActive(true);
    }
	public void Close()
	{
        toolOptions.SetActive(false);
    }
	public void Delete()
	{
		Destroy (gameObject);
	}



}
