using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthManager : MonoBehaviour
{
    [Header("ÃÖ´ë Ã¼·Â")]
    public int Health;

    public TextMeshProUGUI lifeCount;
    public TextMeshProUGUI lifeText;

    public void Show()
    {
        lifeCount.text = $"¸ñ¼û{Health}";
    }

    public void Result(int minusHealth)
    {
        Health -= minusHealth;
        if (Health <= 0)
        {
            print("´Ô µÚÁü");
        }
    }

}
