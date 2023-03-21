using UnityEngine;

public class Abilities : MonoBehaviour
{
    [SerializeField] private Projectile prefab; 

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Fire(prefab);
    }
    //create a projectile with the same position as the player
    void Fire(Projectile projectilePrefab)
    {   
        Vector3 localForward = transform.rotation * Vector3.forward;
        Vector3 spawnPosition = transform.position + localForward * 2f;        

        var projectile = Instantiate(projectilePrefab, spawnPosition, transform.rotation); 
        projectile.Shot();

    }

}
