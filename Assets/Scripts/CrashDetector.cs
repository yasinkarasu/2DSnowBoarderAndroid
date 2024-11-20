using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float loadDelay = 0.5f;
    [SerializeField] ParticleSystem CrashEffect;

    void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            CrashEffect.Play();
            Invoke("ReloadScene", loadDelay);
        }    
    }

    void ReloadScene()
    {
        // Mevcut sahneyi yeniden yükler
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
