using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightingDiod : RandomEvent
{
    [SerializeField]
    private SpriteRenderer sprite;
    private bool isStart;

    [Header("�ٲٱ� �� �޹��")]
    [SerializeField]
    private SpriteRenderer prevBackGround;

    [Header("�ٲ� �޹��")]
    [SerializeField]
    private Sprite nextBackGround;

    public override void Enter()
    {
        base.Enter();
        isStart = true;
    }

    public void flipDiod()
    {
        if(isStart)
        {
            StartCoroutine(TimerSecond());
            isStart = false;
        }
    }

    private IEnumerator TimerSecond()
    {
        sprite.flipX = true;
        prevBackGround.sprite = nextBackGround;
        yield return new WaitForSeconds(0.7f);
        TimerManager.instance.OnDead?.Invoke(true);
    }

    public override void Exit()
    {
        base.Exit();
        
    }
}
