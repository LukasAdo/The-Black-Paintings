using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordCheck23 : MonoBehaviour
{
    public GameObject question23;
    public GameObject question24;
    public AudioSource question23Audio;
    public GameObject hint67;
    public GameObject hint68;
    public GameObject hint69;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    // Start is called before the first frame update
    public Button submitAnswerBtn; // assign a UI button object in editor
    public InputField answerInput; // assign a UI inputfield object in editor
    public string a1_right_answer = "Jalapeno"; // make it public and edit the answer in editor if you like


    public void Awake()
    {
        // add event listener when button for submitting answer is clicked
        submitAnswerBtn.onClick.AddListener(() =>
        {
            // validate the answer
            if (answerInput.text == a1_right_answer)
            {
                // success
                question23Audio.Play();
                Debug.Log("Correct");
                Destroy(question23);
                question24.SetActive(true);
            }
            else
            {
                Debug.Log("Wrong");
            }

        });

    }
    public void hint1Click()
    {

        hint67.SetActive(true);

    }
    public void hint1closeClick()
    {

        Destroy(hint67);
        Destroy(button1);

    }
    public void hint2Click()
    {

        hint68.SetActive(true);

    }
    public void hint2closeClick()
    {

        Destroy(hint68);
        Destroy(button2);

    }
    public void hint3Click()
    {

        hint69.SetActive(true);

    }
    public void hint3closeClick()
    {

        Destroy(hint69);
        Destroy(button3);

    }
}