using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class build : MonoBehaviour
{
    


    void Update()
    {
        if (image1.havei1 && image2.havei2 && image3.havei3 && image4.havei4)
        {
            Destroy(gameObject);
        }
    }
}
