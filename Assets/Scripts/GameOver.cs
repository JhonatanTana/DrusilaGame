using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) // Certifique-se que o jogador tem a tag "Player"
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Reinicia a cena
            SceneManager.LoadScene("GameOver"); // Carrega a cena de Game Over

        }
    }
}
