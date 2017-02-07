using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class SearchForTools : MonoBehaviour {

	// Use this for initialization

	public InputField inField;
	public string inFieldText;
	public GameObject toolSearchedFor;
	public Canvas toolOptions;
	public GameObject indicator;

	public float maxCountTime = 10;
	public float countdownTime;

	private bool countdown;

	private GameObject[] Indicators; 

	void Update()
	{

		inFieldText = inField.text.ToString();

		if (countdown)
		{
			countdownTime -= Time.deltaTime;
			if (countdownTime <= 0)
			{
				countdown = false;
				countdownTime = 0;
				Indicators = GameObject.FindGameObjectsWithTag("Indicator");
				for (int i = 0; i < Indicators.Length; i++)
				{
					Destroy(Indicators[i]);
					
				}

			}
		}

	}

	public void Search()
	{

		toolSearchedFor = GameObject.Find (inFieldText);
		if(toolSearchedFor != null)
		{
			toolOptions = toolSearchedFor.GetComponentInChildren<Canvas>();

			Instantiate (indicator, toolSearchedFor.transform.position, Quaternion.identity);

			countdownTime = maxCountTime;
			countdown = true;
			//toolOptions.enabled = true;
		}

	}
    public void PullToMainScreen()
    {
        toolSearchedFor = GameObject.Find(inFieldText);
        if (toolSearchedFor != null)
        {
            toolSearchedFor.transform.position = new Vector3(0, 0, 0);
        }
    }
}
