using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float delayBeforeReload = 1f;
    [SerializeField] ParticleSystem crashEffect;

    PlayerController playerController;

    void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
    }
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D collision)
    {
        int layerIndex = LayerMask.NameToLayer("Floor");
        if (collision.gameObject.layer == layerIndex)
        {
            playerController.canControlPlayer = false;
            crashEffect.Play();
            Invoke("ReloadScene", delayBeforeReload);

            //Create a simple burst animation first before restarting the scene

            //SceneManager.LoadScene(0);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}

