using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public CubeData data;

    private void OnMouseDown()
    {
        Debug.Log($"Clicked {data.displayName}! Info: {data.info}");
    }
}
