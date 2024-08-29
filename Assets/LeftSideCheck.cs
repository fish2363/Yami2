using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LeftSideCheck : RandomEvent
{
    public SoonsooBandoMakeManager makeManager;

    private bool isStart;

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
        if (isStart && makeManager != null)
        {
            Collider2D[] overlap = Physics2D.OverlapBoxAll(transform.position, size, 0);
            if (overlap != null)
            {
                int leftCnt = 0;

                for (int i = 0; i < overlap.Length; i++)
                {
                    bool isJunjaLeft = overlap[i].GetComponent<MovingJunja>().isLeft;

                    if (isJunjaLeft == true)
                    {
                        ++leftCnt;
                    }
                }
                currentLeftCnt = leftCnt;
                makeManager.CheckCount(currentLeftCnt, true);
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
