using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class TimerManager : MonoBehaviour
{
    public static TimerManager instance;

    [HideInInspector]
    public float timer;
    public TextMeshProUGUI textMeshPro;

    private static bool isTimerStart = false;

    public Action OnDead;

    private void Awake()
    {
        instance = this;
    }

    public void StartTimer()
    {
        isTimerStart = true;
    }

    private void Update()
    {
        if(isTimerStart)
        {
            timer -= Time.deltaTime;
            string testText = timer.ToString().Substring(0, 4);
            textMeshPro.text = $"{testText}초 남았습니다";
            if (timer < 0)
            {
                isTimerStart = false;
                OnDead?.Invoke();
            }
            
        }
    }
}
