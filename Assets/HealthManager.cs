using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthManager : MonoBehaviour
{
    [Header("최대 체력")]
    public int Health;

    public TextMeshProUGUI lifeCount;
    public TextMeshProUGUI lifeText;

    public void Show()
    {
        lifeCount.text = Health.ToString();
        lifeText.text = "목숨";
    }

    public void Result(int minusHealth)
    {
        Health -= minusHealth;
    }

}
