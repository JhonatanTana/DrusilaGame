using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public void RestartGame() {
        SceneManager.LoadScene("Nivel1"); // Altere para o nome real da sua cena de gameplay
    }

    public void QuitGame() {
        Application.Quit();
    }
}
