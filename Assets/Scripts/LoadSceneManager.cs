using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadSceneManager : MonoBehaviour
{
    public Button first_scene_button;
    public Button second_scene_button;
    public Button third_scene_button;
    public Button main_scene_button;

    public string first_scene_name;
    public string second_scene_name;
    public string third_scene_name;
    public string main_scene_name;
    // Start is called before the first frame update
    void Start()
    {
        if (first_scene_button)
        {
            first_scene_button.onClick.AddListener(GoToFirstLevel);
            Debug.Log("Added First Scene Button Listener.");
        }
        if (second_scene_button)
        {
            second_scene_button.onClick.AddListener(GoToSecondLevel);
            Debug.Log("Added Second Scene Button Listener.");
        }
        if (third_scene_button)
        {
            third_scene_button.onClick.AddListener(GoToThirdLevel);
            Debug.Log("Added Third Scene Button Listener.");
        }
        if (main_scene_button)
        {
            main_scene_button.onClick.AddListener(GoToMainLevel);
            Debug.Log("Added Main Scene Button Listener.");
        }
    }

    private void GoToFirstLevel()
    {
        Debug.Log("In Go to First Level.");
        SceneManager.LoadScene(first_scene_name);
    }

    private void GoToSecondLevel()
    {
        Debug.Log("In Go to Second Level.");
        SceneManager.LoadScene(second_scene_name);
    }

    private void GoToThirdLevel()
    {
        Debug.Log("In Go to Third Level.");
        SceneManager.LoadScene(third_scene_name);
    }

    private void GoToMainLevel()
    {
        Debug.Log("In Go to Main Level.");
        SceneManager.LoadScene(main_scene_name);
    }
}
