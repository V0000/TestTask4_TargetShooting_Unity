using UnityEngine;

public class ViewController : MonoBehaviour
{
    // camera sensitivity
    [SerializeField] private float sensitivity = 5.0f;
    //movement restrictions
    [SerializeField] private float minimumVerticalAngle = -90.0f;
    [SerializeField] private float maximumVerticalAngle = 90.0f;
    
    private float currentVerticalAngle = 0.0f;
    private float currentHorizontalAngle = 0.0f;

    void Update()
    {
            //get mouse position
            float mouseX = Input.GetAxis("Horizontal");
            float mouseY = Input.GetAxis("Mouse Y");


        //rotate cam horizontally
        currentHorizontalAngle += mouseX * sensitivity;

        //rotate cam vertically
        currentVerticalAngle -= mouseY * sensitivity;

        currentVerticalAngle = Mathf.Clamp(currentVerticalAngle, minimumVerticalAngle, maximumVerticalAngle);
        transform.localEulerAngles = new Vector3(currentVerticalAngle, currentHorizontalAngle, 0);
    }
}
