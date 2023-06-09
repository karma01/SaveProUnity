using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] int timeGone =3;
    MeshRenderer renderer;
    Rigidbody rgb;
    private void Start()
    {

        renderer = GetComponent<MeshRenderer>();
        rgb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
       if(Time.time>timeGone)
        {
            rgb.useGravity = true;
           renderer.enabled = true;

        }
    }
}
