using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
            StartCoroutine(WaitDie());
            print("´Ô µÚÁü");
        }
    }

    private IEnumerator WaitDie()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(0);
    }

}
