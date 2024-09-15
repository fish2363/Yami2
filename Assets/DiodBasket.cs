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
    private int currentBallCount;

    public void SetRandDiod(bool pDiod)
    {
        if(pDiod)
        {
            isWhatDiod.text = "p형입니다";
            needBallCount = 3;
        }
        else
        {
            isWhatDiod.text = "n형입니다";
            needBallCount = 5;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            if (currentBallCount == needBallCount)
                TimerManager.instance.OnDead?.Invoke(true);
            else
                currentBallCount++;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            if (currentBallCount == needBallCount)
                TimerManager.instance.OnDead?.Invoke(true);
            else
                currentBallCount--;
        }
    }
}
