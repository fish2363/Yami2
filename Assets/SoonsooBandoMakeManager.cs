using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoonsooBandoMakeManager : RandomEvent
{
    public override void Enter()
    {
        base.Enter();
        GetComponentInChildren<LeftSideCheck>();
        GetComponentInChildren<SideCheck>();
    }
}
