using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomPN : RandomEvent
{
    [SerializeField]
    private DiodBasket diodBasket;


    public override void Enter()
    {
        int i = Random.Range(0, 2);
        if (i > 0)
            diodBasket.SetRandDiod(false);
        else
            diodBasket.SetRandDiod(true);
    }
}
