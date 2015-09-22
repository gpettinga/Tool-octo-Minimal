using UnityEngine;
using System.Collections;

public class MagnetizeToTool : MonoBehaviour 
{

	public bool timeActive = false;

	public float timer; 

	public GameObject toolConnectorPoint;
	public GameObject connectingTool;

	public Vector3 offSet = new Vector3 (1.5f, 0, 0);

	private float timerLimit = 1.0f;



	void OnTriggerEnter2D(Collider2D tool)
	{
		if (tool.CompareTag("Tool"))
		{
			connectingTool = tool.transform.gameObject;
			//timer = 0.0f;
			timeActive = true;
			connectingTool.transform.position = this.gameObject.transform.position;

		}
	}
	void OnTriggerExit2D(Collider2D tool)
	{
		if (tool.CompareTag("Tool"))
		{
			tool.transform.parent = null;
			timeActive = false;
		}

	}

	// Update is called once per frame
	void Update () 
	{
		if(timeActive)
			timer += Time.deltaTime;
		else
		timer = 0.0f;

		if (timer > timerLimit)
		{
			connectingTool.transform.parent = this.gameObject.transform;

		}

	}
}
