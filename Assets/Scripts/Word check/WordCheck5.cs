using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordCheck5 : MonoBehaviour
{
    public GameObject question5;
    public GameObject question6;
    public GameObject Room2;
    public AudioSource question5Audio;
    public GameObject hint13;
    public GameObject hint14;
    public GameObject hint15;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject bgimage1;
    public GameObject bgimage2;
    // Start is called before the first frame update
    public Button submitAnswerBtn; // assign a UI button object in editor
    public InputField answerInput; // assign a UI inputfield object in editor
    public string a1_right_answer = "Rome"; // make it public and edit the answer in editor if you like


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
                Destroy(question5);
                Room2.SetActive(true);
                Destroy(bgimage1);
                bgimage2.SetActive(true);
            }
            else
            {
                Debug.Log("Wrong");
            }

        });

    }
    public void onClick()
    {
        Destroy(Room2);
        question5Audio.Play();
        question6.SetActive(true);

    }
    public void hint1Click()
    {

        hint13.SetActive(true);

    }
    public void hint1closeClick()
    {

        Destroy(hint13);
        Destroy(button1);

    }
    public void hint2Click()
    {

        hint14.SetActive(true);

    }
    public void hint2closeClick()
    {

        Destroy(hint14);
        Destroy(button2);

    }
    public void hint3Click()
    {

        hint15.SetActive(true);

    }
    public void hint3closeClick()
    {

        Destroy(hint15);
        Destroy(button3);

    }
}