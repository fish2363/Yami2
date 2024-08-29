using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class HoldObject : RandomEvent, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [HideInInspector] public Transform parentAfterDrag;

    private bool isStart;
    public bool isFinish;

    public override void Enter()
    {
        base.Enter();
        isStart = true;
        print(isStart);
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (isStart)
        {
            parentAfterDrag = transform.parent;
            transform.SetAsLastSibling();
            gameObject.GetComponent<Image>().raycastTarget = false;
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        if(isStart)
            transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (isStart)
        {
            transform.SetParent(parentAfterDrag);

            if(!isFinish)
                gameObject.GetComponent<Image>().raycastTarget = true;
        }
    }
}
