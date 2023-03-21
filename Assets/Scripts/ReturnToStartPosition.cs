using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnToStartPosition : MonoBehaviour
{    
    [SerializeField] float returnSpeed = 2f;

    private Transform startPosition;
    private Quaternion startRotation;
    private bool isReturning;

    private void Start()
    {
        startRotation = transform.rotation;
        isReturning = false;
    }


    private void Update()
    {
        if (isReturning)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, startRotation, Time.deltaTime * returnSpeed);

            //stop when in position
            if (Quaternion.Angle(transform.rotation, startRotation) < 0.01f)
            {
                transform.rotation = startRotation;
                isReturning = false;
            }
        }
        //need to return
        if ((Quaternion.Angle(transform.rotation, startRotation) > 100f))
        {
            isReturning = true;
        }

    }

    public void Return()
    {
        isReturning = true;
    }
}
