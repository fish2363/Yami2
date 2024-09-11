using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveBall : MonoBehaviour,IDragHandler
{
    public void OnDrag(PointerEventData eventData)
    {
        Vector2 mouseDir = Input.mousePosition;
        transform.position = mouseDir;
    }
}
