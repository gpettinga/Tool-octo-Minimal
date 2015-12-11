using UnityEngine;
using System.Collections;

public class PointTowardTool : MonoBehaviour {

	public GameObject targetTool;
	public Transform target;
	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		targetTool = GameObject.FindGameObjectWithTag("Indicator");
			if (targetTool != null)
			{	
			//Debug.Log ("look at tool");
				target = targetTool.transform;
			
				Vector3 dir = target.position - transform.position;
				float angle = Mathf.Atan2(dir.y,dir.x) * Mathf.Rad2Deg;
				transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

			}
			else if (!targetTool)
			{
				//Debug.Log ("Return to Zero");
				transform.rotation = Quaternion.Euler(0,0,0);
			}
	}
}
