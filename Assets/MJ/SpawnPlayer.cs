using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    [SerializeField] private GameObject _playerPrefab;
    public List<GameObject> SpawnPoint = new List<GameObject>();
    private float _randompoint;

    private void Awake()
    {
        _randompoint = Random.Range(0, 3);
    }
    private void Start()
    {
       switch(_randompoint)
        {
            case 0: _playerPrefab.transform.position = SpawnPoint[0].transform.position;
                return;
            case 1: _playerPrefab.transform.position = SpawnPoint[1].transform.position;
                break;
            case 2: _playerPrefab.transform.position = SpawnPoint[2].transform.position;
                break;
        }
    }
}
