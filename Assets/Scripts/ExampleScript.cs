using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    // Exercise 2
    string[] a ={"Cat","Dog","Car","Pizza","Hat","Fish","Tree","Monkey","Ball","Bird"};   
        int b = (9);
        string score = "";

    
        while ( b > 2) 
        {
           score = score + a [Random.Range(0,9)]+" ";
            b--;
        }
        Debug.Log(score);

    }

 }