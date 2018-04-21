using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BrickSmasher : MonoBehaviour {

    public ParticleSystem particles;
    
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        Instantiate(particles, transform.position, Quaternion.identity);
    }
    
}
