using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{


    public void PlayGame()
    {

        int selectedCharacter = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);

        GameManager.instance.CharIndex = selectedCharacter;

        Debug.Log("Back on Clock!! Mamba Mentallity");
        
        SceneManager.LoadScene("monster_game_scene");
    }
}
// class