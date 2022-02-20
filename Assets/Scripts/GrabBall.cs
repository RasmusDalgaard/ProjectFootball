using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabBall : MonoBehaviour
{
    public Transform destination;
    [SerializeField] int shootingPower;

    void OnMouseDown()
    {
        GetComponent<SphereCollider>().enabled = false;
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;

        this.transform.position = destination.position;
        this.transform.parent = GameObject.Find("Destination").transform;

    }

    void OnMouseUp()
    {
        GetComponent<SphereCollider>().enabled = true;
        this.transform.parent = null;
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<Rigidbody>().AddForce(destination.transform.forward * shootingPower);
    }

}

