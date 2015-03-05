using UnityEngine;
using System.Collections;

public class ToolSpecificInformation : MonoBehaviour {

	public string toolNumber;
	private int totalToolCount;
	public TextMesh toolNumberText;
	public Vector3 whereIsTool;
	public int toolType;

	public void Awake()
	{
		totalToolCount = GameObject.FindGameObjectsWithTag ("CBG_Tool").Length;
		toolNumber = totalToolCount.ToString();

		toolNumberText = GetComponentInChildren<TextMesh> ();

		GetComponentInChildren<TextMesh> ().text = toolNumber;

		whereIsTool = this.transform.position;

	}

	public void Update()
	{
		whereIsTool = this.transform.position;	
	}

}
