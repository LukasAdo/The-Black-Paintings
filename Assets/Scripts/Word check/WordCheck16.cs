using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordCheck16 : MonoBehaviour
{
    public GameObject question16;
    public GameObject question17;
    public AudioSource question16Audio;
    public GameObject hint46;
    public GameObject hint47;
    public GameObject hint48;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    // Start is called before the first frame update
    public Button submitAnswerBtn; // assign a UI button object in editor
    public InputField answerInput; // assign a UI inputfield object in editor
    public string a1_right_answer = "Peninsular war"; // make it public and edit the answer in editor if you like


    public void Awake()
    {
        // add event listener when button for submitting answer is clicked
        submitAnswerBtn.onClick.AddListener(() =>
        {
            // validate the answer
            if (answerInput.text == a1_right_answer)
            {
                // success
                question16Audio.Play();
                Debug.Log("Correct");
                Destroy(question16);
                question17.SetActive(true);
            }
            else
            {
                Debug.Log("Wrong");
            }

        });

    }
    public void hint1Click()
    {

        hint46.SetActive(true);

    }
    public void hint1closeClick()
    {

        Destroy(hint46);
        Destroy(button1);

    }
    public void hint2Click()
    {

        hint47.SetActive(true);

    }
    public void hint2closeClick()
    {

        Destroy(hint47);
        Destroy(button2);

    }
    public void hint3Click()
    {

        hint48.SetActive(true);

    }
    public void hint3closeClick()
    {

        Destroy(hint48);
        Destroy(button3);

    }
}