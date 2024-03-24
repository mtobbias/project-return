using UnityEngine;

public class DestroyOnTouch : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
           GameObject collidedObject = collision.gameObject;
            Destroy(collidedObject);
    }
}
