using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour
{
    public float timeLeft = 100f;
    public Text timer_Text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        timer_Text.text = "Time left: " + Mathf.Floor(timeLeft);
        if (timeLeft < 0)
        {
            SceneManager.LoadScene("End");
        }
    }
}
