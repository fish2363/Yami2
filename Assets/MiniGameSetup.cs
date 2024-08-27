using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class MiniGameSetup : MonoBehaviour
{
    private TextMeshProUGUI text;
    private bool isWaiting;
    private float waitingTime = 4f;
    private TimerManager timer;


    private void Awake()
    {
        timer = FindAnyObjectByType<TimerManager>();
        text = GameObject.Find("StartWaitText").GetComponent<TextMeshProUGUI>();
        text.gameObject.SetActive(false);

        timer.OnDead += EndGame;
    }

    private void EndGame()
    {
        RandomEvent[] game = GetComponentsInChildren<RandomEvent>();

        foreach (RandomEvent randomEvent in game)
        {
            randomEvent.Exit();
        }
            GameManager.Instance.EndPanel();
            Destroy(gameObject);
    }

    private void OnEnable()
    {
        text.gameObject.SetActive(true);
        isWaiting = true;
    }

    private void StartGame()
    {
        isWaiting = false;
        text.text = "";
        text.gameObject.SetActive(false);

        RandomEvent[] game = GetComponentsInChildren<RandomEvent>();

        foreach (RandomEvent randomEvent in game)
        {
            randomEvent.Enter();
        }
    }
    private void Update()
    {
        if(isWaiting)
        {
            waitingTime -= Time.deltaTime;
            text.text = waitingTime.ToString().Substring(0,1);
            if (waitingTime < 1)
                StartGame();
        }
    }
}
