using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishPoint : MonoBehaviour
{
    private GameObject _player;

    private void Awake()
    {
        _player = GameObject.Find("Player");
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == _player.name)
        {
            TimerManager.instance.OnDead?.Invoke(true);
        }
    }
}
