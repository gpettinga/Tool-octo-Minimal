using UnityEngine;
using System.Collections;

public class SelectableToolObject : MonoBehaviour
{

    public bool isSelected;
    public GameObject DragfromThisPoint;

    void Start()
    {

        DragfromThisPoint.SetActive(false);

    }

    void Update()
    {

        if (isSelected == false)
        {

            DragfromThisPoint.SetActive(false);

        }


    }
    
}
