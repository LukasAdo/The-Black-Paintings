using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordCheck10 : MonoBehaviour
{
    public GameObject question10;
    public GameObject question11;
    public GameObject Room3;
    public AudioSource question10Audio;
    public GameObject hint28;
    public GameObject hint29;
    public GameObject hint30;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject bgimage2;
    public GameObject bgimage3;
    // Start is called before the first frame update
    public Button submitAnswerBtn; // assign a UI button object in editor
    public InputField answerInput; // assign a UI inputfield object in editor
    public string a1_right_answer = "King"; // make it public and edit the answer in editor if you like


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
                Destroy(question10);
                Room3.SetActive(true);
                Destroy(bgimage2);
                bgimage3.SetActive(true);
            }
            else
            {
                Debug.Log("Wrong");
            }

        });

    }
    public void onClick()
    {
        Destroy(Room3);
        question10Audio.Play();
        question11.SetActive(true);

    }
    public void Click()
    {

        question10Audio.Play();
        question11.SetActive(true);

    }
    public void hint1Click()
    {

        hint28.SetActive(true);

    }
    public void hint1closeClick()
    {

        Destroy(hint28);
        Destroy(button1);

    }
    public void hint2Click()
    {

        hint29.SetActive(true);

    }
    public void hint2closeClick()
    {

        Destroy(hint29);
        Destroy(button2);

    }
    public void hint3Click()
    {

        hint30.SetActive(true);

    }
    public void hint3closeClick()
    {

        Destroy(hint30);
        Destroy(button3);

    }
}