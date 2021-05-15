using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordCheck20 : MonoBehaviour
{
    public GameObject question20;
    public GameObject question21;
    public GameObject Room5;
    public AudioSource question20Audio;
    public GameObject hint58;
    public GameObject hint59;
    public GameObject hint60;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject bgimage4;
    public GameObject bgimage5;
    // Start is called before the first frame update
    public Button submitAnswerBtn; // assign a UI button object in editor
    public InputField answerInput; // assign a UI inputfield object in editor
    public string a1_right_answer = "Betrayal"; // make it public and edit the answer in editor if you like


    public void Awake()
    {
        // add event listener when button for submitting answer is clicked
        submitAnswerBtn.onClick.AddListener(() =>
        {
            // validate the answer
            if (answerInput.text == a1_right_answer)
            {
                // success
                
                Debug.Log("Correct");
                Destroy(question20);
                Room5.SetActive(true);
                Destroy(bgimage4);
                bgimage5.SetActive(true);
            }
            else
            {
                Debug.Log("Wrong");
            }

        });

    }
    public void onClick()
    {
        Destroy(Room5);
        question20Audio.Play();
        question21.SetActive(true);

    }
    public void hint1Click()
    {

        hint58.SetActive(true);

    }
    public void hint1closeClick()
    {

        Destroy(hint58);
        Destroy(button1);

    }
    public void hint2Click()
    {

        hint59.SetActive(true);

    }
    public void hint2closeClick()
    {

        Destroy(hint59);
        Destroy(button2);

    }
    public void hint3Click()
    {

        hint60.SetActive(true);

    }
    public void hint3closeClick()
    {

        Destroy(hint60);
        Destroy(button3);

    }
}