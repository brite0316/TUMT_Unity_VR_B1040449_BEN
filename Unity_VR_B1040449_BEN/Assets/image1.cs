using UnityEngine;

public class image1 : MonoBehaviour
{
    public static bool havei1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "垃圾桶")
        {
            Destroy(gameObject);
            havei1 = true;
            print("摧毀1");
        }
    }
}
