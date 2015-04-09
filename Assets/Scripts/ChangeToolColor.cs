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
		toolRend.material = toolMats [1];
	}
	public void Blue()
	{
		toolRend.material = toolMats [2];
	}
	public void Yellow()
	{
		toolRend.material = toolMats [3];
	}
	public void Grey()
	{
		toolRend.material = toolMats [4];
	}
	public void Purple()
	{
		toolRend.material = toolMats [5];
	}
	public void White()
	{
		toolRend.material = toolMats [6];
	}
	public void Black()
	{
		toolRend.material = toolMats [7];
	}
}
