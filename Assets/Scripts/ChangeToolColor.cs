using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeToolColor : MonoBehaviour 
{
	public Material[] toolMats;
	public Renderer toolRend;
	// Use this for initialization
	void Start () 
	{
		toolRend = GetComponent<Renderer> ();
	}
	
	public void Red()
	{
		toolRend.material = toolMats [0];
	}
	public void Green()
	{
		
	}
	public void Blue()
	{
		
	}
	public void Yellow()
	{
		
	}
	public void Grey()
	{
		
	}
	public void Purple()
	{
		
	}
}
