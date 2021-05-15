using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordCheck12 : MonoBehaviour
{
    public GameObject question12;
    public GameObject question13;
    public AudioSource question12Audio;
    public GameObject hint34;
    public GameObject hint35;
    public GameObject hint36;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    // Start is called before the first frame update
    public Button submitAnswerBtn; // assign a UI button object in editor
    public InputField answerInput; // assign a UI inputfield object in editor
    public string a1_right_answer = "Loss of hearing"; // make it public and edit the answer in editor if you like


    public void Awake()
    {
        // add event listener when button for submitting answer is clicked
        submitAnswerBtn.onClick.AddListener(() =>
        {
            // validate the answer
            if (answerInput.text == a1_right_answer)
            {
                // success
                question12Audio.Play();
                Debug.Log("Correct");
                Destroy(question12);
                question13.SetActive(true);
            }
            else
            {
                Debug.Log("Wrong");
            }

        });

    }
    public void hint1Click()
    {

        hint34.SetActive(true);

    }
    public void hint1closeClick()
    {

        Destroy(hint34);
        Destroy(button1);

    }
    public void hint2Click()
    {

        hint35.SetActive(true);

    }
    public void hint2closeClick()
    {

        Destroy(hint35);
        Destroy(button2);

    }
    public void hint3Click()
    {

        hint36.SetActive(true);

    }
    public void hint3closeClick()
    {

        Destroy(hint36);
        Destroy(button3);

    }
}