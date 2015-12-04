using UnityEngine;
using System.Collections;

public class DontRenderOffScreen : MonoBehaviour 
{	
	private SpriteRenderer sprRend;

	void Start()
	{
		sprRend = GetComponent<SpriteRenderer> ();
	}
	void OnBecameInvisible()
	{
		Debug.Log ("Invisible");
		sprRend.enabled = false;
	}
	void OnBecameVisible()
	{
		Debug.Log ("Visible");
		sprRend.enabled = true;
	}
}
