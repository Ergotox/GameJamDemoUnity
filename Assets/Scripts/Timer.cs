using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    public string levelToLoad;
    private float timer= 70f;
    private Text timerSeconds;
    void Start()
    {
        timerSeconds = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timerSeconds.text = timer.ToString("f0");
        if(timer<=0){
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
