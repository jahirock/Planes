using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attributes : MonoBehaviour
{
    int a;
    int b;

    void Start()
    {
        string sum = a == b ? "es igual" : "no es igual";
        Debug.Log(sum);
    }

}
