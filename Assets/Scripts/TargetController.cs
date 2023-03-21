using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    [SerializeField] AudioClip destroySound;
    [SerializeField] AudioSource SoundSource;

    [SerializeField, Tooltip("The object will be destroyed when the projectile touches it")] 
    bool isDestroyedWhenToched;
    [SerializeField, Tooltip("When the projectile touches the object, a sound will play")] 
    bool isSoundWhenToched;
    [SerializeField, Tooltip("Do need to count points?")] 
    bool isCalculatePoints;
    [SerializeField, Tooltip("An object that displays points")] 
    TextMeshPro pointsText;

    private int points;
    //Target already shooted
    bool isDown = false;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Projectile" && isDestroyedWhenToched)
        {
            DestroyObject();
        }

        if (isSoundWhenToched)
        {
            SoundSource.PlayOneShot(destroySound);
        }


        if (isCalculatePoints && !isDown)
        {
            points = int.Parse(pointsText.text);
            isDown = true;
            points += 1;
            pointsText.text = points.ToString();
        }

    }

    void DestroyObject()
    {        
        Destroy(gameObject);        
    }
}
