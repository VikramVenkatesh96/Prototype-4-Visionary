using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnforceBounds : MonoBehaviour
{
    void Update()
    {
        Vector3 newPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);

        //For x coordinate
        if (transform.position.x < -7.5f) {
            newPos.x = -7.5f;
        }
        else if(transform.position.x > 1.7f){
            newPos.x = 1.7f;
        }
        //For y coordinate
        if (transform.position.z < -4.5f)
        {
            newPos.z = -4.5f;
        }
        else if (transform.position.z > 4.5f)
        {
            newPos.z = 4.5f;
        }

        transform.position = newPos;
    }
}
