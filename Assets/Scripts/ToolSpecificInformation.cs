using UnityEngine;
using System.Collections;

public class ToolSpecificInformation : MonoBehaviour {

	public string toolNumber;
	private int totalToolCount;
	public TextMesh toolNumberText;

	public void Awake()
	{
		totalToolCount = GameObject.FindGameObjectsWithTag ("Tool").Length;
		toolNumber = totalToolCount.ToString();

		toolNumberText = GetComponentInChildren<TextMesh> ();

		GetComponentInChildren<TextMesh> ().text = toolNumber;

	}

}
