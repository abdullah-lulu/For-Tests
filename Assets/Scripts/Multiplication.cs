using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Multiplication : MonoBehaviour
{
    void Start()
    {
        int num1;
        int num2;
        Debug.Log("5 multiplication");
        for (int x = 1; x <= 10; x++)
        {
            num2 = 5;
            int s = Multiply(x,num2);
            Debug.Log(x + " x "+ num2 + " = " + s);




        }
    
    }


    int Multiply(int x, int num2)
    {
        int sum = x * num2;
        return sum;
    }
}