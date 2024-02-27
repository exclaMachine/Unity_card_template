using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    public GameObject Canvas;
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        bIsOverDropZone = true;
        dropZone = collision.gameObject;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        bIsOverDropZone = false;
        dropZone = null;
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
