using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class HealthManager : MonoBehaviour
{
    [Header("�ִ� ü��")]
    public int Health;

    public TextMeshProUGUI lifeCount;
    public TextMeshProUGUI lifeText;

    public void Show()
    {
        lifeCount.text = $"���{Health}";
    }

    public void Result(int minusHealth)
    {
        Health -= minusHealth;
        if (Health <= 0)
        {
            StartCoroutine(WaitDie());
            print("�� ����");
        }
    }

    private IEnumerator WaitDie()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(0);
    }

}
