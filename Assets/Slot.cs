using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Slot : RandomEvent,IDropHandler
{
    public static int finish;
    private bool isEnd = true;
    public Vector2 size;

    public override void Enter()
    {
        base.Enter();
        isEnd = false;
    }

    public void OnDrop(PointerEventData eventData)
    {
        if(!isEnd)
        {
            GameObject drop = eventData.pointerDrag;
            HoldObject holdObject = drop.GetComponent<HoldObject>();
            print(drop.name);
            holdObject.parentAfterDrag = transform;
            holdObject.isFinish = true;
            holdObject.GetComponent<Image>().raycastTarget = false;
            finish++;
            isEnd = true;
        }
    }

    public override void Exit()
    {
        base.Exit();
        finish = 0;
    }

    private void Update()
    {
        if(finish == 4)
        {
            TimerManager.instance.OnDead?.Invoke(true);
            finish = 0;
        }
    }
}
