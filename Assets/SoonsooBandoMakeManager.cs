using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoonsooBandoMakeManager : RandomEvent
{
    private int currentLeftCnt = 0;
    private int currentRightCnt = 0;


    public override void Enter()
    {
        base.Enter();
        GetComponentInChildren<LeftSideCheck>().makeManager = this;
        GetComponentInChildren<SideCheck>().makeManager = this;
    }

    public void CheckCount(int count,bool left)
    {
        if(left)
            currentLeftCnt = count;
        else if(!left)
            currentRightCnt = count;
    }

    private void Update()
    {
        print($"{currentLeftCnt}¿Þ{currentRightCnt}¿ì");
        if (currentRightCnt == 5 && currentLeftCnt == 3)
            TimerManager.instance.OnDead(true);
    }

    public override void Exit()
    {
        base.Exit();
        currentRightCnt = 0;
        currentLeftCnt = 0;
        GetComponentInChildren<LeftSideCheck>().makeManager = null;
        GetComponentInChildren<SideCheck>().makeManager = null;
    }
}
