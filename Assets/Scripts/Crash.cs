using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crash : MonoBehaviour
{
    [SerializeField] float delay = 0.5f;
    [SerializeField] ParticleSystem effect;
    [SerializeField] AudioClip crashSFX;

    bool hasCrashed=false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground" && !hasCrashed)
        {
            hasCrashed = true;
            FindAnyObjectByType<Player>().DisableController();
            effect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("reloadScene", delay);   
        }
    }

    void reloadScene()
    {
        SceneManager.LoadScene(2);
    }
}
