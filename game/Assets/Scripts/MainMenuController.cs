using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("Back on Clock!! Mamba Mentallity");
        SceneManager.LoadScene("gameplay");
    }
}
// class