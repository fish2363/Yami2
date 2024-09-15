using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveBall : RandomEvent,IDragHandler
{
    private bool isStart;

    public override void Enter()
    {
        isStart = true;
    }

    public void OnDrag(PointerEventData eventData)
    {
        if(isStart)
        {
            Vector2 mouseDir = Input.mousePosition;
            transform.position = mouseDir;
        }
    }
}
