using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleGame : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnStart()
    {
        SceneManager.LoadScene("GameScene");
    }
}
