using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordCheck7 : MonoBehaviour
{
    public GameObject question7;
    public GameObject question8;
    public AudioSource question7Audio;
    public GameObject hint19;
    public GameObject hint20;
    public GameObject hint21;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    // Start is called before the first frame update
    public Button submitAnswerBtn; // assign a UI button object in editor
    public InputField answerInput; // assign a UI inputfield object in editor
    public string a1_right_answer = "Tapestry"; // make it public and edit the answer in editor if you like


    public void Awake()
    {
        // add event listener when button for submitting answer is clicked
        submitAnswerBtn.onClick.AddListener(() =>
        {
            // validate the answer
            if (answerInput.text == a1_right_answer)
            {
                // success
                question7Audio.Play();
                Debug.Log("Correct");
                Destroy(question7);
                question8.SetActive(true);
            }
            else
            {
                Debug.Log("Wrong");
            }

        });

    }
    public void onClick()
    {

        question7Audio.Play();
        question8.SetActive(true);

    }
    public void hint1Click()
    {

        hint19.SetActive(true);

    }
    public void hint1closeClick()
    {

        Destroy(hint19);
        Destroy(button1);

    }
    public void hint2Click()
    {

        hint20.SetActive(true);

    }
    public void hint2closeClick()
    {

        Destroy(hint20);
        Destroy(button2);

    }
    public void hint3Click()
    {

        hint21.SetActive(true);

    }
    public void hint3closeClick()
    {

        Destroy(hint21);
        Destroy(button3);

    }
}