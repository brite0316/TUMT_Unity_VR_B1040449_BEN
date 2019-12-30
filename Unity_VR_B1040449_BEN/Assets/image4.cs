using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class image4 : MonoBehaviour
{
    public static bool havei4;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "垃圾桶")
        {
            Destroy(gameObject);
            havei4 = true;
            print("摧毀4");
        }
    }
}
