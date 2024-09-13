using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomPN : RandomEvent
{
    public TextMeshProUGUI text;

    [SerializeField]
    private DiodBasket diodBasket;


    public override void Enter()
    {
        int i = Random.Range(0, 2);
        if (i > 0)
        {
            text.text = "n���Դϴ�";
            diodBasket.SetRandDiod(false);
        }
        else
        {
            text.text = "p���Դϴ�";
            diodBasket.SetRandDiod(true);
        }
    }
}
