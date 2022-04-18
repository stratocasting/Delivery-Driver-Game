using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;


    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("ops");
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if  (other.tag == "Package" && hasPackage == false)
        {
            Debug.Log("package picked up");    
            hasPackage = true;
        }

        if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Delivered Package");
            hasPackage = false;
        }
    }
    
}
