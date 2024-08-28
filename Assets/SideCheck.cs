using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SideCheck : RandomEvent
{
    private bool isStart;
    public bool isLeft;

    private int currentRightCnt = 0;
    public int currentLeftCnt = 0;

    [SerializeField]
    private Vector2 size;

    public override void Enter()
    {
        base.Enter();
        isStart = true;
    }

    private void Update()
    {
        if(isStart)
        {
            Collider2D[] overlap = Physics2D.OverlapBoxAll(transform.position,size,0);
            if(overlap != null)
            {
                int leftCnt = 0;
                int rightCnt = 0;

                for(int i = 0; i<overlap.Length; i++)
                {
                    bool isJunjaLeft = overlap[i].GetComponent<MovingJunja>().isLeft;

                    if (isLeft == isJunjaLeft)
                    {
                        ++leftCnt;
                    }
                    if(isLeft == !isJunjaLeft)
                    {
                        ++rightCnt;
                    }
                }
                currentRightCnt = rightCnt;
                currentLeftCnt = leftCnt;
            print($"{currentRightCnt}오른쪽");
            print($"{currentLeftCnt}왼쪽");
            }

            if(currentLeftCnt ==3 && currentRightCnt == 5)
            {
                TimerManager.instance.OnDead();
            }

            // 여기서 전자의 개수를 체크하고
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, size);
        Gizmos.color = Color.white;
    }
}
