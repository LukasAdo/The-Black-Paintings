using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordCheck : MonoBehaviour
{
    public GameObject question1;
    public GameObject question2;
    public GameObject hint1;
    public GameObject hint2;
    public GameObject hint3;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public AudioSource question1Audio;
    // Start is called before the first frame update
    public Button submitAnswerBtn; // assign a UI button object in editor
    public InputField answerInput; // assign a UI inputfield object in editor
    public string a1_right_answer = "Martin Zapater"; // make it public and edit the answer in editor if you like
    

    public void Awake()
    {
        // add event listener when button for submitting answer is clicked
        submitAnswerBtn.onClick.AddListener(() =>
        {
            // validate the answer
            if (answerInput.text == a1_right_answer)
            {
                // success
                question1Audio.Play();
                Debug.Log("Correct");
                Destroy(question1);
                question2.SetActive(true);
            }
            else
            {
                Debug.Log("Wrong");
            }

        });

    }
    public void hint1Click()
    {

        hint1.SetActive(true);

    }
    public void hint1closeClick()
    {

        Destroy(hint1);
        Destroy(button1);

    }
    public void hint2Click()
    {

        hint2.SetActive(true);

    }
    public void hint2closeClick()
    {

        Destroy(hint2);
        Destroy(button2);

    }
    public void hint3Click()
    {

        hint3.SetActive(true);

    }
    public void hint3closeClick()
    {

        Destroy(hint3);
        Destroy(button3);

    }


}