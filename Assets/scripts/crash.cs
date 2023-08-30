using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class crash : MonoBehaviour
{
    [SerializeField] float loadTime = 2f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip audioClip;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "ground")
        {
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(audioClip);
            Invoke("ReloadScene", loadTime);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
