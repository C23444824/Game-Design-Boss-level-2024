using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LevelDesignProjectilePrefab : MonoBehaviour
{
    public float projectileSpeed;
    public float projectileImpactRadius;
    public float projectileLifetime;
    private Vector3 projectileRotation;
    public GameObject player;

    public GameObject explosionVisuals;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        //destroys the projectile after projectileLifetime amount of time
        Destroy(gameObject, projectileLifetime);
    }

    // Update is called once per frame
    void Update()
    {
        projectileRotation = transform.eulerAngles;
        //moves the projectile forward
        transform.position += transform.forward * projectileSpeed * Time.deltaTime;
        
        
    }
    //checks if the projectile collides with an object
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag != "Boss")
        {
            if (other.tag == "Bat")
            {
                print("batted");
                transform.eulerAngles = player.transform.eulerAngles;
                gameObject.tag = "Batted";
            }
            else
            {
                print("hit");
                //if the projectile collides with an object, it will explode
                Explode();
            }
        }

      
    }
    
    void Explode()
    {
        print("exploded");
        //creates a sphere at the projectile's position with a radius of projectileImpactRadius
        Collider[] colliders = Physics.OverlapSphere(transform.position, projectileImpactRadius);
        //checks if the sphere collides with the player object
        foreach (Collider nearbyObject in colliders)
        {
            if (nearbyObject.tag == "Player")
            {
                //if the sphere collides with the player, the player will take damage
                //nearbyObject.GetComponent<PlayerHealth>().TakeDamage(10); //this requires a PlayerHealth script on the player
                Debug.Log("Player Hit!");
            }
        }

        if (explosionVisuals!=null)
        {
            Instantiate(explosionVisuals, transform.position, transform.rotation); //if there is an explosionVisuals object, it will be instantiated
        }
        
        
        //destroys the projectile
        Destroy(gameObject);
    }
}
