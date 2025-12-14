using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button startBtn;

    public void GameLevel()
    {
        SceneManager.LoadScene(1);
    }
}
