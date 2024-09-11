using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTransform : MonoBehaviour
{
    [SerializeField] private Transform _StandingTransform;

    private CarMove carMove;

    private void Awake()
    {
        carMove = FindAnyObjectByType<CarMove>();
    }

    private void Update()
    {
        transform.position = _StandingTransform.position;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Car"))
        {
            carMove.isStop = true;
            StartCoroutine(DeadRoutine());
        }
    }

    private IEnumerator DeadRoutine()
    {
        yield return new WaitForSeconds(1f);
        TimerManager.instance.OnDead?.Invoke(false);
    }
}
