using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="SO/List")]
public class SequencingSOList : ScriptableObject
{
    public List<RandomStageSO> randomStageSOs = new();
}
