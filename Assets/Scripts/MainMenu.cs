using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void OpenOptions()
    {
        // Aquí puedes abrir otra ventana o panel
        Debug.Log("Opciones abiertas");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
