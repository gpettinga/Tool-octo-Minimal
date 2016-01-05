using UnityEngine;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;


public class ScreenSelect : MonoBehaviour
{
    bool isSelecting = false;
    Vector3 mousePosition1;
    public GameObject dragablePoint;
   

    //public GameObject selectionCirclePrefab;

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            mousePosition1 = Input.mousePosition;
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider == null)
            {
                isSelecting = true;
            }
            
        }

        if (Input.GetMouseButtonUp(0))
        {
            var selectedObjects = new List<SelectableToolObject>();
            foreach (var selectableObject in FindObjectsOfType<SelectableToolObject>())
            {
                if (IsWithinSelectionBounds(selectableObject.gameObject))
                {
                    selectedObjects.Add(selectableObject);
                }

                
            }
            isSelecting = false;

            foreach (var selectableObject in selectedObjects)
            {
               // Debug.Log(selectableObject.transform.parent);
                selectableObject.transform.parent = selectedObjects[0].transform;
            }

            //******Fix, Needs a way to determine what object to drag from *****

            if (selectedObjects.Count != 0)
            {
                dragablePoint = selectedObjects[0].gameObject;
                dragablePoint.GetComponent<SelectableToolObject>().DragfromThisPoint.SetActive(true);
            }
            else {
                return;
            }
        }

        //*************************do something with the seleced tools***********************\\
        if (isSelecting)
        {
            foreach (var selectableObject in FindObjectsOfType<SelectableToolObject>())
            {
                if (IsWithinSelectionBounds(selectableObject.gameObject))
                {
                   
                    if (selectableObject.isSelected == false)
                    {
                        selectableObject.isSelected = true;
                     
                    }

                }
                else
                {
                    selectableObject.isSelected = false;
                    selectableObject.transform.parent = null;
                    //Debug.Log("Not in selection box" + selectableObject);
                }
            }
        }
      
    }

    public bool IsWithinSelectionBounds(GameObject gameObject)
    {
        if(!isSelecting)
        {
            return false;
        }

        var camera = Camera.main;
        var viewportBounds = Utils.GetViewportBounds(camera, mousePosition1, Input.mousePosition);

        return viewportBounds.Contains(camera.WorldToViewportPoint(gameObject.transform.position));
        
        //return viewportBounds.Contains(camera.ViewportToWorldPoint(gameObject.transform.position));
        //return viewportBounds.Contains(camera.ScreenToViewportPoint(gameObject.transform.position));
        //return viewportBounds.Contains(camera.ViewportToScreenPoint(gameObject.transform.position));
    }
    void OnGUI()
    {
        if (isSelecting)
        {
            var rect = Utils.GetScreenRect(mousePosition1, Input.mousePosition);
            Utils.DrawScreenRect(rect, new Color(0.8f, 0.8f, 0.95f, 0.25f));
            Utils.DrawScreenRectBorder(rect, 2, new Color(0.8f, 0.8f, 0.95f));
        }
    }
}
