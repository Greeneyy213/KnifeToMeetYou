using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelRotation : MonoBehaviour
{



    void Update()
    {
        transform.Rotate(0, 0, 90 * Time.deltaTime, Space.World);
    }
}
