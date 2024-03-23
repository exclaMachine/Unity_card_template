using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardZoom : MonoBehaviour
{
    public GameObject Canvas;
    private GameObject ZoomCard;

    public void Awake()
    {
        Canvas = GameObject.Find("Canvas");
    }

    public void OnHoverEnter()
    {
        ZoomCard = Instantiate(gameObject, new Vector2(Input.mousePosition.x, Input.mousePosition.y), Quaternion.identity);
        ZoomCard.transform.SetParent(Canvas.transform, false);

        RectTransform rect = ZoomCard.GetComponent<RectTransform>();
        rect.sizeDelta = new Vector2(120, 172);
    }

    public void OnHoverExit()
    {
        Destroy(ZoomCard);
    }
}
