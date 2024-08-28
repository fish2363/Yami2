using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideInCar : RandomEvent
{
    public bool isStartSideInCar;
    Vector2 mouseDir;

    private TimerManager timer;

    private void Awake()
    {
        timer = FindAnyObjectByType<TimerManager>();
    }

    public override void Enter()
    {
        base.Enter();
        isStartSideInCar = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(isStartSideInCar)
        {
            mouseDir = GameManager.GetMousePointer();
            transform.position = new Vector2(mouseDir.x,0); 
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Car"))
        {
            print("Ãæµ¹");
            timer.OnDead();
        }
    }

    public override void Exit()
    {
        isStartSideInCar = false;
    }
}
