using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordCheck11 : MonoBehaviour
{
    public GameObject question11;
    public GameObject question12;
    public AudioSource question11Audio;
    public GameObject hint31;
    public GameObject hint32;
    public GameObject hint33;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    // Start is called before the first frame update
    public Button submitAnswerBtn; // assign a UI button object in editor
    public InputField answerInput; // assign a UI inputfield object in editor
    public string a1_right_answer = "Lead in paint"; // make it public and edit the answer in editor if you like


    public void Awake()
    {
        // add event listener when button for submitting answer is clicked
        submitAnswerBtn.onClick.AddListener(() =>
        {
            // validate the answer
            if (answerInput.text == a1_right_answer)
            {
                // success
                question11Audio.Play();
                Debug.Log("Correct");
                Destroy(question11);
                question12.SetActive(true);
            }
            else
            {
                Debug.Log("Wrong");
            }

        });

    }
    public void hint1Click()
    {

        hint31.SetActive(true);

    }
    public void hint1closeClick()
    {

        Destroy(hint31);
        Destroy(button1);

    }
    public void hint2Click()
    {

        hint32.SetActive(true);

    }
    public void hint2closeClick()
    {

        Destroy(hint32);
        Destroy(button2);

    }
    public void hint3Click()
    {

        hint33.SetActive(true);

    }
    public void hint3closeClick()
    {

        Destroy(hint33);
        Destroy(button3);

    }

}