 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Button_SC : MonoBehaviour
{
    public string Desired_Scene;
    public Button Push_Me;
    // Start is called before the first frame update
    void Start()
    {
        Push_Me.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void TaskOnClick()
    {
        SceneManager.LoadScene(Desired_Scene);
    }
}
