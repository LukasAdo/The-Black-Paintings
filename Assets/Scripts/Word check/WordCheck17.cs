using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordCheck17 : MonoBehaviour
{
    public GameObject question17;
    public GameObject question18;
    public AudioSource question17Audio;
    public GameObject hint49;
    public GameObject hint50;
    public GameObject hint51;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    // Start is called before the first frame update
    public Button submitAnswerBtn; // assign a UI button object in editor
    public InputField answerInput; // assign a UI inputfield object in editor
    public string a1_right_answer = "One can’t look"; // make it public and edit the answer in editor if you like


    public void Awake()
    {
        // add event listener when button for submitting answer is clicked
        submitAnswerBtn.onClick.AddListener(() =>
        {
            // validate the answer
            if (answerInput.text == a1_right_answer)
            {
                // success
                question17Audio.Play();
                Debug.Log("Correct");
                Destroy(question17);
                question18.SetActive(true);
            }
            else
            {
                Debug.Log("Wrong");
            }

        });

    }
    public void hint1Click()
    {

        hint49.SetActive(true);

    }
    public void hint1closeClick()
    {

        Destroy(hint49);
        Destroy(button1);

    }
    public void hint2Click()
    {

        hint50.SetActive(true);

    }
    public void hint2closeClick()
    {

        Destroy(hint50);
        Destroy(button2);

    }
    public void hint3Click()
    {

        hint51.SetActive(true);

    }
    public void hint3closeClick()
    {

        Destroy(hint51);
        Destroy(button3);

    }
}