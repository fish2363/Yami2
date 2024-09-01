using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGameManager : MonoBehaviour
{
    public static MiniGameManager Instance;

    [SerializeField]
    private SequencingSOList sequencingSOList;
    [SerializeField]
    private TextManager textManager;
    [SerializeField]
    private TimerManager timerManager;
    [SerializeField]
    private HealthManager healthManager;

    private RandomStageSO newStageSO;
    private float time;
    private GameObject gameSequencing = null;
    private int textNum;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        StartGame();
    }

    public void StartGame()
    {
        if (gameSequencing != null)
            gameSequencing.SetActive(false);

        healthManager.lifeCount.text = "";

        int randNum = Random.Range(0, sequencingSOList.randomStageSOs.Count);
        newStageSO = sequencingSOList.randomStageSOs[randNum];

        time = newStageSO.time;
        textNum = newStageSO.textNum;
        gameSequencing = newStageSO.sequencing;
        print(gameSequencing);

        textManager.InputText(textNum);
        Instantiate(gameSequencing);
        gameSequencing.SetActive(true);
        timerManager.timer = time;
        gameSequencing = null;
    }
}
