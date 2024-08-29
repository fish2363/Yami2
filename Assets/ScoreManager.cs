using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;

    public void ScoreManeger(int plusScore)
    {
        textMeshPro.text = plusScore.ToString();
    }
}
