using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class HomeRestart : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // get the button name
    // from my thoughts i think loading up a new scene is fine

    public void GameHomeRestart()
    {
        string currentSelectedObject = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
        if (currentSelectedObject == "Restart")
        {
            Debug.Log("Restart Button");
            SceneManager.LoadScene("monster_game_scene");
        }
        else if (currentSelectedObject == "Home")
        {
            SceneManager.LoadScene("MainController");
            
        }
    }
}
