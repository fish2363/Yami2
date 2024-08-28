using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextManager : MonoBehaviour
{
    public string[] text;
    public TextMeshProUGUI textMeshPro;

    public void InputText(int textNum)
    {
        textMeshPro.text = text[textNum];
    }
}
