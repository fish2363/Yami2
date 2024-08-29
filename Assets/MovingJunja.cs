using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MovingJunja : RandomEvent,IDragHandler,IDropHandler,IBeginDragHandler
{
    private bool isStart;
    public bool isLeft;

    public override void Enter()
    {
        base.Enter();
        isStart = true;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {

    }

    public void OnDrag(PointerEventData eventData)
    {
        if(isStart)
        {
            transform.position = Input.mousePosition;
        }
    }

    public void OnDrop(PointerEventData eventData)
    {

    }
}
