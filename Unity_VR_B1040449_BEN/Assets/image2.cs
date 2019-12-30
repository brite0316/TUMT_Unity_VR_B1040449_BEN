using UnityEngine;

public class image2 : MonoBehaviour
{
    public static bool havei2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "垃圾桶")
        {
            Destroy(gameObject);
            havei2 = true;
            print("摧毀2");
        }
    }
}
