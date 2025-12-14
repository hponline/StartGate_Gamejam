using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject escPanel;
    public bool isActive = true;



    private void Update()
    {
        if (!isActive)
        {
            escPanel.SetActive(true);
        }
        else
            escPanel.SetActive(false);
    }
    public void Restart()
    {
        SceneManager.LoadScene(1);
    }
}
