using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    [SerializeField] private GameObject _objectPrefab;
    public List<GameObject> ObjectTransform;
    private int _randomInt;


    private void Awake()
    {
        _randomInt = Random.Range(1, 4);
    }

    private void Start()
    {
        if (_randomInt == 1)
        {
            _objectPrefab.transform.position = ObjectTransform[0].transform.position;
        }
        else if (_randomInt == 2)
        {
            _objectPrefab.transform.position = ObjectTransform[1].transform.position;
        }
        else
        {
            _objectPrefab.transform.position = ObjectTransform[2].transform.position;
        }
    }

    private void Update()
    {
        switch(_randomInt)
        {
            case 1:
                _objectPrefab.transform.SetParent(ObjectTransform[0].transform);
                break;
            case 2:
                _objectPrefab.transform.SetParent(ObjectTransform[1].transform);
                break;
            case 3:
                _objectPrefab.transform.SetParent(ObjectTransform[2].transform);
                break;
        }    
    }
}
