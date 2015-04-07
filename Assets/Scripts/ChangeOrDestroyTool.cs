using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeOrDestroyTool : MonoBehaviour {

	public bool mouseOverTool;
	public Canvas toolOptions;

	void Start()
	{
		toolOptions = GetComponentInChildren<Canvas> ();
		toolOptions.enabled = false;
	
	}

	void OnMouseEnter()
	{
		mouseOverTool = true;
	}

	void OnMouseExit()
	{
		mouseOverTool = false;
	}

	void Update()
	{
		if (Input.GetMouseButtonDown(1)&& mouseOverTool)
		{
			toolOptions.enabled = true;
		}
	}
	public void Close()
	{
		toolOptions.enabled = false;
	}

	public void Delete()
	{
		Destroy (gameObject);
	}
}
