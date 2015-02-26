using UnityEngine;
using System.Collections;

public class ShowUI : MonoBehaviour 
{

	public GameObject UIPanel1;
	public GameObject UIPanel2;
	private bool panelActive = false;

	void Start()
	{
		UIPanel1.SetActive(false);
		UIPanel2.SetActive(false);
	}
	// Update is called once per frame
	void Update () 
	{
	
		if (Input.GetMouseButtonDown(1) && !panelActive)
		{
			UIPanel1.SetActive(true);
			UIPanel2.SetActive(true);

			panelActive = true;
		}

		else if (Input.GetMouseButtonDown(1) && panelActive) 
		{
			UIPanel1.SetActive(false);
			UIPanel2.SetActive(false);

			panelActive = false;
		}
	}
}
