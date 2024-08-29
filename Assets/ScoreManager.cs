using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public TextMeshProUGUI textMeshPro;

    private int currentScore;

    private void OnEnable()
    {
        instance = this;
    }

    public void ScoreManeger(int plusScore)
    {
        currentScore += plusScore;
        textMeshPro.text = $"{currentScore}";
    }
}
