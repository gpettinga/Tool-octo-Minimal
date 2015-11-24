using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeToolColor : MonoBehaviour 
{
	public Material[] toolMats;
	public Renderer toolRend;
	public TextMesh txtColor;
	// Use this for initialization
	void Start () 
	{
		toolRend = GetComponent<Renderer> ();
		txtColor = GetComponentInChildren<TextMesh> ();
	}
	
	public void Red()
	{
		toolRend.material = toolMats [0];
		txtColor.color = Color.black;
	}
	public void Green()
	{
		toolRend.material = toolMats [1];
		txtColor.color = Color.black;
	}
	public void Blue()
	{
		toolRend.material = toolMats [2];
		txtColor.color = Color.black;
	}
	public void Yellow()
	{
		toolRend.material = toolMats [3];
		txtColor.color = Color.black;
	}
	public void Grey()
	{
		toolRend.material = toolMats [4];
		txtColor.color = Color.black;
	}
	public void Purple()
	{
		toolRend.material = toolMats [5];
		txtColor.color = Color.white;
	}
	public void White()
	{
		toolRend.material = toolMats [6];
		txtColor.color = Color.black;
	}
	public void Black()
	{
		toolRend.material = toolMats [7];
		txtColor.color = Color.white;

	}
	public void Orange()
	{
		toolRend.material = toolMats [8];
		txtColor.color = Color.black;
	}
	public void LightBlue()
	{
		toolRend.material = toolMats [9];
		txtColor.color = Color.black;
	}

	public void RedText()
	{
		txtColor.color = Color.red;
	}
	public void BlackText()
	{
		txtColor.color = Color.black;
	}
	public void WhiteText()
	{
		txtColor.color = Color.white;
	}
	public void BlueText()
	{
		txtColor.color = Color.blue;
	}
	public void GreenText()
	{
		txtColor.color = Color.green;
	}
	public void YellowText()
	{
		txtColor.color = Color.yellow;
	}
}
