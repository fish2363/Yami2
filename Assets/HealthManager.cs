using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthManager : MonoBehaviour
{
    [Header("�ִ� ü��")]
    public int Health;

    public TextMeshProUGUI lifeCount;
    public TextMeshProUGUI lifeText;

    public void Show()
    {
        lifeCount.text = Health.ToString();
        lifeText.text = "���";
    }

    public void Result(int minusHealth)
    {
        Health -= minusHealth;
    }

}
