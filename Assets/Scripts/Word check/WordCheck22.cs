using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordCheck22 : MonoBehaviour
{
    public GameObject question22;
    public GameObject question23;
    public AudioSource question22Audio;
    public GameObject hint64;
    public GameObject hint65;
    public GameObject hint66;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    // Start is called before the first frame update
    public Button submitAnswerBtn; // assign a UI button object in editor
    public InputField answerInput; // assign a UI inputfield object in editor
    public string a1_right_answer = "Jupiter"; // make it public and edit the answer in editor if you like


    public void Awake()
    {
        // add event listener when button for submitting answer is clicked
        submitAnswerBtn.onClick.AddListener(() =>
        {
            // validate the answer
            if (answerInput.text == a1_right_answer)
            {
                // success
                question22Audio.Play();
                Debug.Log("Correct");
                Destroy(question22);
                question23.SetActive(true);
            }
            else
            {
                Debug.Log("Wrong");
            }

        });

    }
    public void hint1Click()
    {

        hint64.SetActive(true);

    }
    public void hint1closeClick()
    {

        Destroy(hint64);
        Destroy(button1);

    }
    public void hint2Click()
    {

        hint65.SetActive(true);

    }
    public void hint2closeClick()
    {

        Destroy(hint65);
        Destroy(button2);

    }
    public void hint3Click()
    {

        hint66.SetActive(true);

    }
    public void hint3closeClick()
    {

        Destroy(hint66);
        Destroy(button3);

    }
}