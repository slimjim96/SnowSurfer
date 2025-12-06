using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowtrail : MonoBehaviour
{
    [SerializeField] ParticleSystem finishParticle;
    SurfaceEffector2D surfaceEffector2D;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        int layerIndex = LayerMask.NameToLayer("Floor");
        if (collision.gameObject.layer == layerIndex)
        {
            finishParticle.Play();
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
         int layerIndex = LayerMask.NameToLayer("Floor");
        if (collision.gameObject.layer == layerIndex)
        {
        finishParticle.Stop();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
