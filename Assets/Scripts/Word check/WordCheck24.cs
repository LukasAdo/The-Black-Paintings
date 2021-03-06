using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordCheck24 : MonoBehaviour
{
    public GameObject question24;
    public GameObject question25;
    public AudioSource question24Audio;
    public GameObject hint70;
    public GameObject hint71;
    public GameObject hint72;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    // Start is called before the first frame update
    public Button submitAnswerBtn; // assign a UI button object in editor
    public InputField answerInput; // assign a UI inputfield object in editor
    public string a1_right_answer = "Belladonna"; // make it public and edit the answer in editor if you like


    public void Awake()
    {
        // add event listener when button for submitting answer is clicked
        submitAnswerBtn.onClick.AddListener(() =>
        {
            // validate the answer
            if (answerInput.text == a1_right_answer)
            {
                // success
                question24Audio.Play();
                Debug.Log("Correct");
                Destroy(question24);
                question25.SetActive(true);
            }
            else
            {
                Debug.Log("Wrong");
            }

        });

    }
    public void hint1Click()
    {

        hint70.SetActive(true);

    }
    public void hint1closeClick()
    {

        Destroy(hint70);
        Destroy(button1);

    }
    public void hint2Click()
    {

        hint71.SetActive(true);

    }
    public void hint2closeClick()
    {

        Destroy(hint71);
        Destroy(button2);

    }
    public void hint3Click()
    {

        hint72.SetActive(true);

    }
    public void hint3closeClick()
    {

        Destroy(hint72);
        Destroy(button3);

    }
}