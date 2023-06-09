using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
  
    [SerializeField] float wv = 0.5f;
    
    void Start()
    {
        PrintInstructions();

    }

    // Update is called once per frame
    void Update()

    {

        walk();
    }
    void PrintInstructions()
    {
        Debug.Log("Welcome to the Game:");
        Debug.Log("Enjoy this simple game::");
    }
     void walk()
    {
            float zValue = Input.GetAxis("Vertical") * wv * Time.deltaTime;
            float xValue = Input.GetAxis("Horizontal") * wv * Time.deltaTime;
            transform.Translate(xValue, 0, zValue);
       
    }

}
