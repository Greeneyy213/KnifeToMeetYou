using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeThrow : MonoBehaviour
{
    //[HideInInspector]
    //Variables
    public float delay = 1f;
    public GameObject knife;
    public Transform spawnPoint;
    public float speed = 5f;
    public float torque;
    public Rigidbody rb;
    //private Vector3 MousePos;

    bool launched;


    private void Start()
    {
        float turn = Input.GetAxis("Horizontal");
        rb.AddTorque(transform.up * torque * turn);
        
    }


    private void Update()
    {
        delay -= Time.deltaTime;
        if (delay <= 0 && Input.GetKeyDown(KeyCode.E))
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


        Destroy(GameObject.Find("Knife(Clone)"), 1);

        knifeRig.AddForce(spawnPoint.forward * speed, ForceMode.Impulse);
        launched = false;
    }
}
