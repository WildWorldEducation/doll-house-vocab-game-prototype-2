
using System.Collections;
using UnityEngine;

class DragDrop : MonoBehaviour
{
    private Color mouseOverColor = Color.blue;
    private Color originalColor = Color.yellow;
    private bool dragging = false;
    private float distance;

    public static GameObject selected, previousSelected;


    void OnMouseEnter()
    {
        // Debug.Log("enter");
    }

    void OnMouseExit()
    {
        // Debug.Log("exit");
    }

    void OnMouseDown()
    {
        distance = Vector3.Distance(transform.position, Camera.main.transform.position);
        dragging = true;


        if (previousSelected != null)
        {
            previousSelected.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
        }
        selected = this.gameObject;
        selected.GetComponent<SpriteRenderer>().color = new Color(1, 0, 0, 1);
        previousSelected = selected;
        print(selected);
    }

    void OnMouseUp()
    {
        dragging = false;
    }

    void Update()
    {
        if (dragging)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 rayPoint = ray.GetPoint(distance);
            transform.position = rayPoint;
        }
    }
}