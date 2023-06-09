using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreEnter : MonoBehaviour
{
    int n = 0;

    private void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.tag == "enemy")
        {
            n++;
            Debug.Log("You have bumped into " + n + " materials:");
        }



    }
}
 