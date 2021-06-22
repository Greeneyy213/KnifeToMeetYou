using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {

        if (!collision.gameObject.CompareTag("balloon"))
            {
                //Sets the knife as the pinwheels child
                transform.SetParent(collision.gameObject.transform, true);

                Destroy(gameObject.GetComponent<Rigidbody>());
            }
    }
}
