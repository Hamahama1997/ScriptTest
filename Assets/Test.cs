using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        int[] array = { 1, 2, 3, 4, 5 };

        for(int a = 0; a < array.Length; a++)
        {
            Debug.Log(array[a]);
        }

        for (int b = array.Length - 1; 0 <= b; b--)
        {
            Debug.Log(array[b]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}