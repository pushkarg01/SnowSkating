using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustParticle : MonoBehaviour
{
    [SerializeField] ParticleSystem _particleSystem;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            _particleSystem.Play();
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag =="Ground")
        {
            _particleSystem.Stop();
        }
    }
}
