using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionExplosion : MonoBehaviour
{
    public ParticleSystem explosion;


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Instantiate(explosion, collision.gameObject.transform.position, Quaternion.identity);
            explosion.Play();
            Destroy(gameObject);
        }
        
    }


}
