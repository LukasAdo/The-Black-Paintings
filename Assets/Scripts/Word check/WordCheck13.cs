using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordCheck13 : MonoBehaviour
{
    public GameObject question13;
    public GameObject question14;
    public AudioSource question13Audio;
    public GameObject hint37;
    public GameObject hint38;
    public GameObject hint39;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    // Start is called before the first frame update
    public Button submitAnswerBtn; // assign a UI button object in editor
    public InputField answerInput; // assign a UI inputfield object in editor
    public string a1_right_answer = "The sleep of reason produces monsters"; // make it public and edit the answer in editor if you like


    public void Awake()
    {
        // add event listener when button for submitting answer is clicked
        submitAnswerBtn.onClick.AddListener(() =>
        {
            // validate the answer
            if (answerInput.text == a1_right_answer)
            {
                // success
                question13Audio.Play();
                Debug.Log("Correct");
                Destroy(question13);
                question14.SetActive(true);
            }
            else
            {
                Debug.Log("Wrong");
            }

        });

    }
    public void hint1Click()
    {

        hint37.SetActive(true);

    }
    public void hint1closeClick()
    {

        Destroy(hint37);
        Destroy(button1);

    }
    public void hint2Click()
    {

        hint38.SetActive(true);

    }
    public void hint2closeClick()
    {

        Destroy(hint38);
        Destroy(button2);

    }
    public void hint3Click()
    {

        hint39.SetActive(true);

    }
    public void hint3closeClick()
    {

        Destroy(hint39);
        Destroy(button3);

    }
}
