using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OnCollision : MonoBehaviour
{
    // Start is called before the first frame update

    private Vector3 screenPoint;
    private Vector3 offset;
    public ParticleSystem partical;



    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Finish")
        {
            // Destroy the other game object
            Destroy(other.gameObject);

            // Spawn the particle system and increase the y-position
            Vector3 particlePos = other.transform.position;
            particlePos.y += 20.0f; // increase the y-position by 1.0 units
            Instantiate(partical, particlePos, Quaternion.identity);
        }
    }


}
