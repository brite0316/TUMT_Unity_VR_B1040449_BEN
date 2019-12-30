using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class image3 : MonoBehaviour
{
    public static bool havei3;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "垃圾桶")
        {
            Destroy(gameObject);
            havei3 = true;
            print("摧毀3");
        }
    }
}
