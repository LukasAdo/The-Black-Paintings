using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordCheck6 : MonoBehaviour
{
    public GameObject question6;
    public GameObject question7;
    public AudioSource question6Audio;
    public GameObject hint16;
    public GameObject hint17;
    public GameObject hint18;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    // Start is called before the first frame update
    public Button submitAnswerBtn; // assign a UI button object in editor
    public InputField answerInput; // assign a UI inputfield object in editor
    public string a1_right_answer = "Charles III"; // make it public and edit the answer in editor if you like


    public void Awake()
    {
        // add event listener when button for submitting answer is clicked
        submitAnswerBtn.onClick.AddListener(() =>
        {
            // validate the answer
            if (answerInput.text == a1_right_answer)
            {
                // success
                question6Audio.Play();
                Debug.Log("Correct");
                Destroy(question6);
                question7.SetActive(true);
            }
            else
            {
                Debug.Log("Wrong");
            }

        });

    }
    public void onClick()
    {
        
        question6Audio.Play();
        question6.SetActive(true);

    }
    public void hint1Click()
    {

        hint16.SetActive(true);

    }
    public void hint1closeClick()
    {

        Destroy(hint16);
        Destroy(button1);

    }
    public void hint2Click()
    {

        hint17.SetActive(true);

    }
    public void hint2closeClick()
    {

        Destroy(hint17);
        Destroy(button2);

    }
    public void hint3Click()
    {

        hint18.SetActive(true);

    }
    public void hint3closeClick()
    {

        Destroy(hint18);
        Destroy(button3);

    }
}