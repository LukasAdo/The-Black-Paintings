using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordCheck9 : MonoBehaviour
{
    public GameObject question9;
    public GameObject question10;
    public AudioSource question9Audio;
    public GameObject hint25;
    public GameObject hint26;
    public GameObject hint27;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    // Start is called before the first frame update
    public Button submitAnswerBtn; // assign a UI button object in editor
    public InputField answerInput; // assign a UI inputfield object in editor
    public string a1_right_answer = "Love"; // make it public and edit the answer in editor if you like


    public void Awake()
    {
        // add event listener when button for submitting answer is clicked
        submitAnswerBtn.onClick.AddListener(() =>
        {
            // validate the answer
            if (answerInput.text == a1_right_answer)
            {
                // success
                question9Audio.Play();
                Debug.Log("Correct");
                Destroy(question9);
                question10.SetActive(true);
            }
            else
            {
                Debug.Log("Wrong");
            }

        });

    }
    public void onClick()
    {

        question9Audio.Play();
        question10.SetActive(true);

    }
    public void hint1Click()
    {

        hint25.SetActive(true);

    }
    public void hint1closeClick()
    {

        Destroy(hint25);
        Destroy(button1);

    }
    public void hint2Click()
    {

        hint26.SetActive(true);

    }
    public void hint2closeClick()
    {

        Destroy(hint26);
        Destroy(button2);

    }
    public void hint3Click()
    {

        hint27.SetActive(true);

    }
    public void hint3closeClick()
    {

        Destroy(hint27);
        Destroy(button3);

    }
}
