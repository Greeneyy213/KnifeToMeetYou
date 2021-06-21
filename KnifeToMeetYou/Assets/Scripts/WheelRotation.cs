using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelRotation : MonoBehaviour
{


    void Start()
    {

    }



    void Update()
    {
        transform.Rotate(0, 0, 1, Space.World);
    }
}
