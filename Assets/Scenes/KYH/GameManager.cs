using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField]
    private TextManager textManager;
    [SerializeField]
    private TimerManager timerManager;
    public GameObject readyPanel;

    private void Awake()
    {
        readyPanel.SetActive(false);
    }

    private void Start()
    {
        Instance = this;
    }

    public void EndPanel()
    {
        textManager.textMeshPro.text = "";
        timerManager.textMeshPro.text = "";
        readyPanel.SetActive(true);
        StartCoroutine(WaitAndStart());
    }

    private IEnumerator WaitAndStart()
    {
        yield return new WaitForSeconds(3f);
        readyPanel.SetActive(false);
        MiniGameManager.Instance.StartGame();
    }

    public static Vector2 GetMousePointer()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }


}
