using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float throwForce = 100f;
    [SerializeField] private float lifetime = 10.0f;

    void Start()
    {
        //timer for destroy projectiles
        Invoke("DestroyObject", lifetime);
    }

    public void Shot()
    {
        //flight direction
        Vector3 localForward = transform.rotation * Vector3.forward;
        //set force to projectile
        gameObject.GetComponent<Rigidbody>().AddForce(localForward * throwForce, ForceMode.Impulse);
    }

    void DestroyObject()
    {
        Destroy(gameObject);
    }
}
