using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{
    public int num1 = 4;
    public int num2 = 5;
    public int num3;

    void Start()
    {
        num3 = num1 + num2;
        Debug.Log(num3);

        num3 = num1 * num2;
        Debug.Log(num3);
    }

    
    
}
