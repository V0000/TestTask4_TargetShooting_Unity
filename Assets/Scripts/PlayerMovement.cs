using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 10f; 
    [SerializeField] float leftLimit = -3f;
    [SerializeField] float rightLimit = 3f; 

    private void Update()
    {
        //get input
        float horizontalInput = Input.GetAxis("Horizontal");
        
        Vector3 position = transform.position; 
        position.x += horizontalInput * speed * Time.deltaTime;

        //restrict movement
        position.x = Mathf.Clamp(position.x, leftLimit, rightLimit);
        
        transform.position = position; 
    }
}
