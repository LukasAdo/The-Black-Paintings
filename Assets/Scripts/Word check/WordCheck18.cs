using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordCheck18 : MonoBehaviour
{
    public GameObject question18;
    public GameObject question19;
    public AudioSource question18Audio;
    public GameObject hint52;
    public GameObject hint53;
    public GameObject hint54;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    // Start is called before the first frame update
    public Button submitAnswerBtn; // assign a UI button object in editor
    public InputField answerInput; // assign a UI inputfield object in editor
    public string a1_right_answer = "165103"; // make it public and edit the answer in editor if you like


    public void Awake()
    {
        // add event listener when button for submitting answer is clicked
        submitAnswerBtn.onClick.AddListener(() =>
        {
            // validate the answer
            if (answerInput.text == a1_right_answer)
            {
                // success
                question18Audio.Play();
                Debug.Log("Correct");
                Destroy(question18);
                question19.SetActive(true);
            }
            else
            {
                Debug.Log("Wrong");
            }

        });

    }
    public void hint1Click()
    {

        hint52.SetActive(true);

    }
    public void hint1closeClick()
    {

        Destroy(hint52);
        Destroy(button1);

    }
    public void hint2Click()
    {

        hint53.SetActive(true);

    }
    public void hint2closeClick()
    {

        Destroy(hint53);
        Destroy(button2);

    }
    public void hint3Click()
    {

        hint54.SetActive(true);

    }
    public void hint3closeClick()
    {

        Destroy(hint54);
        Destroy(button3);

    }
}