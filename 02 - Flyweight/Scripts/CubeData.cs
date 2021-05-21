using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = nameof(CubeData), menuName = "Data/Flyweight/" + nameof(CubeData))]
public class CubeData : ScriptableObject
{
    public string displayName;
    [TextArea(10, 10)]
    public string info;
}
