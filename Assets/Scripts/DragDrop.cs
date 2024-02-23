using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    private bool bIsDragging = false;
    private bool bIsOverDropZone = false;
    private GameObject dropZone;
    private Vector2 startPosition;

    // Update is called once per frame
    void Update()
    {
        if (bIsDragging)
        {
            transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }
    }

    public void StartDrag()
    {
        startPosition = transform.position;
        bIsDragging = true;
    }

    public void EndDrag()
    {
        bIsDragging = false;
        if (bIsOverDropZone)
        {
            transform.SetParent(dropZone.transform, false);
        }
        else
        {
            transform.position = startPosition;
        }
    }
}
