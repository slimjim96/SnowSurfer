using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float delayBeforeReload = 1f;
    [SerializeField] ParticleSystem finishParticle;
    void OnTriggerEnter2D(Collider2D collision)
    {
        int layerIndex = LayerMask.NameToLayer("Player");
        if (collision.gameObject.layer == layerIndex)
        {
            finishParticle.Play();
            Invoke("ReloadScene", delayBeforeReload);
            //SceneManager.LoadScene(0);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }

}

