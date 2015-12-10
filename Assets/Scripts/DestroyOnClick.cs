using UnityEngine;
using System.Collections;

public class DestroyOnClick : MonoBehaviour 
{
	private GameObject[] Indicators;  
	public void RemoveParticleSystem()
	{
		//Destroy (gameObject);
		Indicators = GameObject.FindGameObjectsWithTag("Indicator");

		for (int i = 0; i < Indicators.Length; i++)
		{
			Destroy(Indicators[i]);
		}

	}

	// Update is called once per frame
//	void Update ()
//	{
//	
//	if(Input.GetMouseButtonDown(0))
//		{
//			Destroy(gameObject);
//		}
//
//	}
}
