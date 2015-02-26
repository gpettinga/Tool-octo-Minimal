using UnityEngine;
using System.Collections;

public class ToolSpecificInformation : MonoBehaviour {

	public int toolNumber;
	private int totalToolCount;

	void Awake()
	{
		totalToolCount = GameObject.FindGameObjectsWithTag ("Tool").Length;
		toolNumber = totalToolCount;
	}

}
