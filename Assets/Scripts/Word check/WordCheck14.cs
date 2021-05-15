using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordCheck14 : MonoBehaviour
{
    public GameObject question14;
    public GameObject question15;
    public AudioSource question14Audio;
    public GameObject hint40;
    public GameObject hint41;
    public GameObject hint42;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    // Start is called before the first frame update
    public Button submitAnswerBtn; // assign a UI button object in editor
    public InputField answerInput; // assign a UI inputfield object in editor
    public string a1_right_answer = "Misery"; // make it public and edit the answer in editor if you like


    public void Awake()
    {
        // add event listener when button for submitting answer is clicked
        submitAnswerBtn.onClick.AddListener(() =>
        {
            // validate the answer
            if (answerInput.text == a1_right_answer)
            {
                // success
                question14Audio.Play();
                Debug.Log("Correct");
                Destroy(question14);
                question15.SetActive(true);
            }
            else
            {
                Debug.Log("Wrong");
            }

        });

    }
    public void hint1Click()
    {

        hint40.SetActive(true);

    }
    public void hint1closeClick()
    {

        Destroy(hint40);
        Destroy(button1);

    }
    public void hint2Click()
    {

        hint41.SetActive(true);

    }
    public void hint2closeClick()
    {

        Destroy(hint41);
        Destroy(button2);

    }
    public void hint3Click()
    {

        hint42.SetActive(true);

    }
    public void hint3closeClick()
    {

        Destroy(hint42);
        Destroy(button3);

    }
}