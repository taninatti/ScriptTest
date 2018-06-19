using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class assighment : MonoBehaviour
{
    void Start()
    {
        int[] array = new int[5];
        array[0] = 1 * 10;
        array[1] = 2 * 10;
        array[2] = 3 * 10;
        array[3] = 4 * 10;
        array[4] = 5 * 10;

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }
        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }
    }
    void Update()
    {

    }
}

