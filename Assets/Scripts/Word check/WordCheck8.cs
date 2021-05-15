using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordCheck8 : MonoBehaviour
{
    public GameObject question8;
    public GameObject question9;
    public AudioSource question8Audio;
    public GameObject hint22;
    public GameObject hint23;
    public GameObject hint24;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    // Start is called before the first frame update
    public Button submitAnswerBtn; // assign a UI button object in editor
    public InputField answerInput; // assign a UI inputfield object in editor
    public string a1_right_answer = "Count of Floridablanca"; // make it public and edit the answer in editor if you like


    public void Awake()
    {
        // add event listener when button for submitting answer is clicked
        submitAnswerBtn.onClick.AddListener(() =>
        {
            // validate the answer
            if (answerInput.text == a1_right_answer)
            {
                // success
                question8Audio.Play();
                Debug.Log("Correct");
                Destroy(question8);
                question9.SetActive(true);
            }
            else
            {
                Debug.Log("Wrong");
            }

        });

    }
    public void onClick()
    {

        question8Audio.Play();
        question9.SetActive(true);

    }
    public void hint1Click()
    {

        hint22.SetActive(true);

    }
    public void hint1closeClick()
    {

        Destroy(hint22);
        Destroy(button1);

    }
    public void hint2Click()
    {

        hint23.SetActive(true);

    }
    public void hint2closeClick()
    {

        Destroy(hint23);
        Destroy(button2);

    }
    public void hint3Click()
    {

        hint24.SetActive(true);

    }
    public void hint3closeClick()
    {

        Destroy(hint24);
        Destroy(button3);

    }
}