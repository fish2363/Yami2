using UnityEngine;

public class DictionaryOpen : MonoBehaviour
{
    [SerializeField] private GameObject _dictionary;
    private bool _isOpen;

    private void Awake()
    {
        _dictionary.SetActive(false);
        _isOpen = true;
    }
    public void OpenDictionary()
    {
        if (_isOpen)
        {
            _dictionary.SetActive(true);
            _isOpen = false;
        }
        else
        {
            _dictionary.SetActive(false);
            _isOpen = true;
        }
    }
}
