using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class SceneSwitcher : MonoBehaviour
{
    // Function to switch scenes by providing the scene name
    void Start()
    {
        // This method is currently empty in this script's implementation.
        // The Start() method is called automatically when the script is first run.
        
    }

    // Method to switch to the "Concert" scene when the corresponding button is pressed
    public void StartConcert()
    {
        // Log a message to the Unity console for debugging purposes
        Debug.Log("Pressing");

        // Load the "Concert" scene using Unity's SceneManager
        SceneManager.LoadScene("Concert");
    }

    // Method to switch to the "MainMenu2" scene when the corresponding button is pressed
    public void ReturntoMainMenu()
    {
        // Load the "MainMenu2" scene using Unity's SceneManager
        SceneManager.LoadScene("MainMenu2");
    }

    // Method to exit the game when the corresponding button is pressed
    public void ExitGame()
    {
        // Log a message to the Unity console indicating the quit request
        Debug.Log("Quit requested");

        // Check if the game is running in the Unity Editor
#if UNITY_EDITOR
        // If running in the Unity Editor, stop playing the scene
        EditorApplication.isPlaying = false;
#else
        // If running outside the Unity Editor, quit the application
        Application.Quit();
#endif
    }
}




