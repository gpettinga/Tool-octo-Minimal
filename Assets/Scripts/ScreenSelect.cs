using UnityEngine;
using System.Collections;

public class ScreenSelect : MonoBehaviour
{

    bool isSelecting = false;
    Vector3 mousePosition1;

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
            isSelecting = false;
        }
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
