using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : RandomEvent
{
    private bool _isStart = false;
    [SerializeField] private GameObject _moveLeft;
    [SerializeField] private GameObject _moveRight;
    [SerializeField] private GameObject _moveCenter;

    [HideInInspector]
    public bool isStop = false;

    public override void Enter()
    {
        base.Enter();
        _isStart = true;
    }

    private void Update()
    {
        if(_isStart == true && !isStop)
        {
        if (transform.position == _moveRight.transform.position && Input.GetKeyDown(KeyCode.A))
        {
            transform.position = _moveCenter.transform.position;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = _moveLeft.transform.position;
        }
        else if (Input.GetKeyDown(KeyCode.D) && transform.position == _moveCenter.transform.position)
            {
                transform.position = _moveRight.transform.position;
            }
            else if(Input.GetKeyDown(KeyCode.D))
            {
                transform.position = _moveCenter.transform.position;
            }
        }
    }

    public override void Exit()
    {
        base.Exit();
    }
}
