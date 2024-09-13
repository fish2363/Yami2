using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DiodBasket : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI ballCount;

    public TextMeshProUGUI isWhatDiod;

    private int needBallCount;

    public void SetRandDiod(bool pDiod)
    {
        if(pDiod)
        {
            isWhatDiod.text = "p���Դϴ�";
            needBallCount = 3;
        }
        else
        {
            isWhatDiod.text = "n���Դϴ�";
            needBallCount = 5;
        }
    }
}
