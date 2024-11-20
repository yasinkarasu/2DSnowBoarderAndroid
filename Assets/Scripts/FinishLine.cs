using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float loadDelay = 0.5f;     
    [SerializeField] ParticleSystem finishEffect; 
    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Player"))
        {
            finishEffect.Play();
            Invoke("LoadNextLevel", loadDelay); 
        }
    }
    void LoadNextLevel()
    {
        if (gameObject.name == "FinishLine1") 
        {
            // Eğer bu birinci Finish Line ise Level2'yi yükle
            SceneManager.LoadScene("Level2");
        }
        else if (gameObject.name == "FinishLine2")
        {
            // Eğer bu ikinci Finish Line ise MainMenu'ye dön
            SceneManager.LoadScene("MainMenu");
        }
    }
}
