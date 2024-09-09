using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class GameChooseManager : MonoBehaviour
{
    [HideInInspector]
    public SequencingSOList sequencing;

    public void GetButtonName()
    {
        GameObject eventButtonObj = EventSystem.current.currentSelectedGameObject;
        ChooseGamePanel chooseGamePanel = eventButtonObj.GetComponent<ChooseGamePanel>();
        //currentSelectModeIndex = chooseGamePanel.chooseNum;
        sequencing = chooseGamePanel.thisSequencing;
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene("GameScene");
    }
}
