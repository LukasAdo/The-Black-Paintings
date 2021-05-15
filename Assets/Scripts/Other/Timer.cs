using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    //public string leveltoload;
    float currentTime = 0f;
    float startingTime = 7200f;

    [SerializeField] Text TimerText;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        TimerText.text = currentTime.ToString("0.0");
        if (currentTime <= 10)
        {
            TimerText.color = Color.red;
        }

        if (currentTime <= 0)
        {
            currentTime = 0;

            //SceneManager.LoadScene(leveltoload);
        }
    }
}
