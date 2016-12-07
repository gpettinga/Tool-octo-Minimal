using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour 
{

	public Vector3 currentPos;

	public Transform goCamPos1;
	public Transform goCamPos2;
	public Transform goCamPos3;
	public Transform goCamPos4;
	public Transform goCamPos5;
	public Transform goCamPos6;
    public Transform goCamAtPosExtra;

    public float transitionTime = .5f;
	public float firstClickTime;
	public float secondClickTime;
	public float doubleClickTime;

	public static bool camAtPos1 = true;
	public static bool camAtPos2 = false;
	public static bool camAtPos3 = false;
	public static bool camAtPos4 = false;
	public static bool camAtPos5 = false;
	public static bool camAtPos6 = false;
    public static bool camAtPosExtra = false;



    // Use this for initialization
    void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		currentPos = transform.position;
		if (camAtPos1)
			{
			transform.position = Vector3.Lerp (currentPos, goCamPos1.position, transitionTime* Time.deltaTime);
			}
		else if (camAtPos2)
			{
			transform.position = Vector3.Lerp (currentPos, goCamPos2.position, transitionTime* Time.deltaTime);
			}
		else if (camAtPos3)
			{
			transform.position = Vector3.Lerp (currentPos, goCamPos3.position, transitionTime* Time.deltaTime);
			}
		else if (camAtPos4)
			{
			transform.position = Vector3.Lerp (currentPos, goCamPos4.position, transitionTime * Time.deltaTime);
			}
		else if (camAtPos5)
			{
				transform.position = Vector3.Lerp (currentPos, goCamPos5.position, transitionTime * Time.deltaTime);
			}
		else if (camAtPos6)
			{
				transform.position = Vector3.Lerp (currentPos, goCamPos6.position, transitionTime * Time.deltaTime);
			}
        else if (camAtPosExtra)
            {
                transform.position = Vector3.Lerp(currentPos, goCamAtPosExtra.position, transitionTime * Time.deltaTime);
            }

    }

	public void atPosOne()
	{
        camAtPosExtra = false;
        camAtPos1 = true;
		camAtPos2 = false;
		camAtPos3 = false;
		camAtPos4 = false;
		camAtPos5 = false;
		camAtPos6 = false;
       
    }
	public void atPosTwo()
	{
        camAtPos2 = true;
        camAtPosExtra = false;
        Debug.Log("fire button 2");
        camAtPos1 = false;
		camAtPos3 = false;
		camAtPos4 = false;
		camAtPos5 = false;
		camAtPos6 = false;
    }
	public void atPosThree()
	{
        camAtPosExtra = false;
        camAtPos1 = false;
		camAtPos2 = false;
		camAtPos3 = true;
		camAtPos4 = false;
		camAtPos5 = false;
		camAtPos6 = false;
        
    }
	public void atPosFour()
	{
        camAtPosExtra = false;
        camAtPos1 = false;
		camAtPos2 = false;
		camAtPos3 = false;
		camAtPos4 = true;
		camAtPos5 = false;
		camAtPos6 = false;
        
    }
	public void atPosFive()
	{
        camAtPosExtra = false;
        camAtPos1 = false;
		camAtPos2 = false;
		camAtPos3 = false;
		camAtPos4 = false;
		camAtPos5 = true;
		camAtPos6 = false;
        
    }
	public void atPosSix()
	{
        camAtPosExtra = false;
        camAtPos1 = false;
		camAtPos2 = false;
		camAtPos3 = false;
		camAtPos4 = false;
		camAtPos5 = false;
		camAtPos6 = true;
        
    }
    public void atPosExtraTools()
    {
        camAtPosExtra = true;
        camAtPos1 = false;
        camAtPos2 = false;
        camAtPos3 = false;
        camAtPos4 = false;
        camAtPos5 = false;
        camAtPos6 = false;
       
    }

    //	void OnGUI()
    //	{
    //		if (!camAtPos1)
    //		{
    //			if(GUI.Button(new Rect(Screen.width/2-100,0,100,20),"1"))
    //				{
    //					
    //					camAtPos1 = true;
    //					camAtPos2 = false;
    //					camAtPos3 = false;
    //					camAtPos4 = false;
    //				}
    //		}
    //		if (!camAtPos2)
    //		{
    //			if(GUI.Button(new Rect(Screen.width/2,0,100,20),"2"))
    //				{
    //					
    //					camAtPos1 = false;
    //					camAtPos2 = true;
    //					camAtPos3 = false;
    //					camAtPos4 = false;
    //				}
    //		}
    //		if (!camAtPos3)
    //		{
    //			if(GUI.Button(new Rect(Screen.width/2+100,0,100,20),"3"))
    //				{
    //					
    //					camAtPos1 = false;
    //					camAtPos2 = false;
    //					camAtPos3 = true;
    //					camAtPos4 = false;
    //				}
    //		}
    //		if (!camAtPos4)
    //		{
    //			if(GUI.Button(new Rect(Screen.width/2+200,0,100,20),"4"))
    //				{
    //					
    //					camAtPos1 = false;
    //					camAtPos2 = false;
    //					camAtPos3 = false;
    //					camAtPos4 = true;
    //				}
    //		}
    //	}

}

