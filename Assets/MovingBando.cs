using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MovingBando : RandomEvent
{
    private bool isLeft = false;
    public Ease ease;

    [SerializeField]
    private Transform leftPoint;
    [SerializeField]
    private Transform rightPoint;
    private bool isStop = false;

    private Rigidbody2D rigid;

    bool isStart;

    public override void Enter()
    {
        isStart = true;
        base.Enter();
        RandomMove();
        rigid = GetComponent<Rigidbody2D>();
    }

    private void RandomMove()
    {
        if(!isStop)
            StartCoroutine(MoveRoutine());
    }

    private IEnumerator MoveRoutine()
    {
        if (isLeft)
        {
            yield return
                transform.DOMoveX(leftPoint.position.x,2).SetEase(ease).WaitForCompletion();
            isLeft = false;
        }
        else
        {
            yield return
                transform.DOMoveX(rightPoint.position.x, 2).SetEase(ease).WaitForCompletion();
            isLeft = true;
        }
        RandomMove();
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0) && isStart)
        {
            isStart = false;
            isStop = true;
            transform.DOKill();
            rigid.velocity = new Vector2(rigid.velocity.x, -6);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ColliderObj"))
            TimerManager.instance.OnDead?.Invoke();

        if(collision.CompareTag("Ground"))
            TimerManager.instance.OnDead?.Invoke();
    }
}
