using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTest : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("mensajes");
        Debug.LogWarning("mandar warning");
        Debug.LogError("mandar error");
        //te muestra el valor de i en cosola en color azul
        int i = 0;
        Debug.LogFormat($"<color=blue>{i}</color>");
    }

}
