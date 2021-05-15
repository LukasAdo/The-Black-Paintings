using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordCheck4 : MonoBehaviour
{
    public GameObject question4;
    public GameObject question5;
    public AudioSource question4Audio;
    public GameObject hint10;
    public GameObject hint11;
    public GameObject hint12;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    // Start is called before the first frame update
    public Button submitAnswerBtn; // assign a UI button object in editor
    public InputField answerInput; // assign a UI inputfield object in editor
    public string a1_right_answer = "Francisco Bayeu"; // make it public and edit the answer in editor if you like


    public void Awake()
    {
        // add event listener when button for submitting answer is clicked
        submitAnswerBtn.onClick.AddListener(() =>
        {
            // validate the answer
            if (answerInput.text == a1_right_answer)
            {
                // success
                question4Audio.Play();
                Debug.Log("Correct");
                Destroy(question4);
                question5.SetActive(true);
            }
            else
            {
                Debug.Log("Wrong");
            }

        });

    }
    public void hint1Click()
    {

        hint10.SetActive(true);

    }
    public void hint1closeClick()
    {

        Destroy(hint10);
        Destroy(button1);

    }
    public void hint2Click()
    {

        hint11.SetActive(true);

    }
    public void hint2closeClick()
    {

        Destroy(hint11);
        Destroy(button2);

    }
    public void hint3Click()
    {

        hint12.SetActive(true);

    }
    public void hint3closeClick()
    {

        Destroy(hint12);
        Destroy(button3);

    }

}