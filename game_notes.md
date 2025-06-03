# canvas Unity Component(User Interface)

**Image**
When adding an image for canvas e.g moon (gameobject), go to canvas, create image, set anchor and on the inspector set as native size.

when you set an image as a background for your game, you use Rect Transfrom and set it to stretch to cover the entire background

**Button**
To create button go to:
right click on canvas, go to UI, go to 
select legacy and button. You can attach an image to the button element. Set native size and click the drop down on the button in the hierarchy tab and click the text and remove the text.  

To add a script to the button element one is required to do the following:
1rst: create a gameobject, name it your name(maincontroller)
2nd: create a script name it your name(maincontrollerscript)

Click the button on hierachy and go to inspector tab   
In the inspector tab, you will see the onclick click the add button: you will be required to add a gameobject and select a function next to the gameobject. Note the function will be in the script(maincontrollerscript) and should be ``public void functionName()``. It is advised to have a single argument for the given function. 


To change scenses between the gameplay and the UI scene, we use UnityEnginge.SceneManagement
```
UnityEngine.SceneManagement.loadScene("scene_name"); // the scene name must be the same with that of what you want to be loaded.
```
The above is used to test if the scene can move from one scene to another.
Once a scene is moved to another new scene, the previous scene(together with the gameobjects) are removed(deleted).

To prevent this, we use ``DontDestroyOnLoad(gameObject);`` this ensures that even after the game is loaded the instance is not deleted. 

# EventSystem
from the current session, it seems using UnityEngine.EventSystems is used to  take what the user has done on the userInterface or on the game.
```
string clickedObject = UnityEngine.EventSystems.eventSystems.current.currentSelectedObject.name;
```

###**ask deepseek what is this**
```
    private int _charIndex;
    public int charIndex
    {
        get { return _charIndex; }
        set { _charIndex = value; }
    }
```
Also what is a singletern pattern

# GameDev Structure
mainMenuController = it is used to handle the changing of the scenes, get the character index selected by the player(UnityEngine.EventSystems).
After the value is selected it is assigned to a variable from the GameManagerClassInstance.selectedCharacter. Note the value must be converted into an integer using 
``int.Parse()``.
The MainMenuController achieves this by attaching the script to 2 buttons for the player characters in the game. Each of this is created using a button. 
MainMenuController.cs file contained a Serialized variable ``Serialized private GameObject[] playerCharacter``. This variable is assigned playerCharacter gameobjects from the Prefabs. It will be used in displaying the selected character.


gameManager = is used to select which player is used in the game: player_1, player_2, player_3, player_4, player_5..
```
Instantiate(playerCharacter[selectedIndex]);
```


# Execution order in Unity Scripts
void Awake();
void OnEnable();
void Start();
