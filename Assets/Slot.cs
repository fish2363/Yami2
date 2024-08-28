using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour,IDropHandler
{
    public static int finish;
    private bool isEnd = false;

    public void OnDrop(PointerEventData eventData)
    {
        if(!isEnd)
        {
            GameObject drop = eventData.pointerDrag;
            HoldObject holdObject = drop.GetComponent<HoldObject>();
            holdObject.parentAfterDrag = transform;
            holdObject.GetComponent<Image>().raycastTarget = false;
            finish++;
            isEnd = true;
        }
    }

    private void Update()
    {
        if(finish == 4)
        {
            TimerManager.instance.OnDead?.Invoke();
            finish = 0;
        }
    }
}
