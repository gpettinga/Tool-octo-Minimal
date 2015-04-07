using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonOpenOptions : MonoBehaviour {

	public GameObject panelToAccess;
	private bool panelVisible = false;

	void Start()
	{
		panelToAccess.SetActive(false);
	}

	public void MakePanelVisible()
	{
		panelVisible = !panelVisible;
	}
	void Update()
	{
		if (panelVisible)
		{
			panelToAccess.SetActive(true);
		}
		else if(!panelVisible)
		{
			panelToAccess.SetActive(false);
		}
	}

}
