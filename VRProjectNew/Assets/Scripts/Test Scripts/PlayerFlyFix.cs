using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFlyFix : MonoBehaviour
{
    public OVRGrabber grabber1;
    public OVRGrabber grabber2;
    private OVRGrabbable grabbable;
    private Rigidbody rb;
    void Start()
    {
        grabbable = gameObject.GetComponent<OVRGrabbable>();
        rb = gameObject.GetComponent<Rigidbody>();
    }
    void Update()
    {
        

        if (grabbable.grabbedBy == grabber1 || grabbable.grabbedBy == grabber1)
        {
            Debug.Log("Grabbed");
            rb.isKinematic = true;
        }
        else {
            rb.isKinematic = false;
        }
    }
}
