using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordCheck3 : MonoBehaviour
{
    public GameObject question3;
    public GameObject question4;
    public AudioSource question3Audio;
    public GameObject hint7;
    public GameObject hint8;
    public GameObject hint9;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    // Start is called before the first frame update
    public Button submitAnswerBtn; // assign a UI button object in editor
    public InputField answerInput; // assign a UI inputfield object in editor
    public string a1_right_answer = "Teacher"; // make it public and edit the answer in editor if you like


    public void Awake()
    {
        // add event listener when button for submitting answer is clicked
        submitAnswerBtn.onClick.AddListener(() =>
        {
            // validate the answer
            if (answerInput.text == a1_right_answer)
            {
                // success
                question3Audio.Play();
                Debug.Log("Correct");
                Destroy(question3);
                question4.SetActive(true);
            }
            else
            {
                Debug.Log("Wrong");
            }

        });

    }
    public void hint1Click()
    {

        hint7.SetActive(true);

    }
    public void hint1closeClick()
    {

        Destroy(hint7);
        Destroy(button1);

    }
    public void hint2Click()
    {

        hint8.SetActive(true);

    }
    public void hint2closeClick()
    {

        Destroy(hint8);
        Destroy(button2);

    }
    public void hint3Click()
    {

        hint9.SetActive(true);

    }
    public void hint3closeClick()
    {

        Destroy(hint9);
        Destroy(button3);

    }
}