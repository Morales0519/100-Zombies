using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quit_Game : MonoBehaviour
{
    
    public Button End_Game;
    // Start is called before the first frame update
    void Start()
    {
        End_Game.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void TaskOnClick()
    {
        Application.Quit();
    }
}
