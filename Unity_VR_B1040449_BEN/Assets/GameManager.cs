using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool haveimage;

    public void Throwpickup()
    {
        print("撿起物件");
    }

    public void ThrowDetach(GameObject obj)
    {
        haveimage = true;
        Destroy(obj);
    }

    public void ThrowHeld()
    {
        print("拿著物件");
    }
}
