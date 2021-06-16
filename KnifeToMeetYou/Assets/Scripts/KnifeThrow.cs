using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeThrow : MonoBehaviour
{
    //Variables
    public GameObject knife;
    public Transform spawnPoint;
    public float speed = 5f;

    bool launched;


    private void Start()
    {

    }

    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            launched = true;
     
    }

    private void FixedUpdate()
    {
        if (launched)
        {
            ThrowKnife();
        }
    }


    private void ThrowKnife()
    {
        GameObject knifeInstance = Instantiate(knife, spawnPoint.position, knife.transform.rotation);
        knifeInstance.transform.rotation = Quaternion.LookRotation(-spawnPoint.forward);
        Rigidbody knifeRig = knifeInstance.GetComponent<Rigidbody>();
        


        knifeRig.AddForce(spawnPoint.forward * speed, ForceMode.Impulse);
        launched = false;
    }
}
