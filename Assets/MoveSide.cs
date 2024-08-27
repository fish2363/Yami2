using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveSide : RandomEvent
{
    private bool isLeft =false;
    public Ease ease;

    public override void Enter()
    {
        base.Enter();
        RandomMove(false);
    }

    private void RandomMove(bool stopMove)
    {
        if (stopMove == true) return;
        StartCoroutine(MoveRoutine());
    }

    private IEnumerator MoveRoutine()
    {
        print(isLeft);
        if(isLeft)
        {
            yield return
                transform.DOMoveX(Random.Range(-8.56f, -13.86f), Random.Range(2, 4)).SetEase(ease).WaitForCompletion();
            //transform.DOLocalMoveX(-3f, Random.Range(1, 3)).OnComplete(() => print("ddd")).WaitForCompletion();
        }
        else if(!isLeft)
        {
            yield return
                transform.DOMoveX(Random.Range(-8.56f, -3.21f), Random.Range(2, 4)).SetEase(ease).WaitForCompletion();
        }
        isLeft = !isLeft;
        RandomMove(false);
    }

    public override void Exit()
    {
        base.Exit();
        RandomMove(true);
        StartCoroutine(EndRoutine());
    }

    private IEnumerator EndRoutine()
    {
        yield return new WaitForSeconds(2f);
        GameManager.Instance.EndPanel();
    }
}
