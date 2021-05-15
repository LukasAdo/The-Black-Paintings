using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordCheck19 : MonoBehaviour
{
    public GameObject question19;
    public GameObject question20;
    public AudioSource question19Audio;
    public GameObject hint55;
    public GameObject hint56;
    public GameObject hint57;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    // Start is called before the first frame update
    public Button submitAnswerBtn; // assign a UI button object in editor
    public InputField answerInput; // assign a UI inputfield object in editor
    public string a1_right_answer = "March the Third"; // make it public and edit the answer in editor if you like


    public void Awake()
    {
        // add event listener when button for submitting answer is clicked
        submitAnswerBtn.onClick.AddListener(() =>
        {
            // validate the answer
            if (answerInput.text == a1_right_answer)
            {
                // success
                question19Audio.Play();
                Debug.Log("Correct");
                Destroy(question19);
                question20.SetActive(true);
            }
            else
            {
                Debug.Log("Wrong");
            }

        });

    }
    public void hint1Click()
    {

        hint55.SetActive(true);

    }
    public void hint1closeClick()
    {

        Destroy(hint55);
        Destroy(button1);

    }
    public void hint2Click()
    {

        hint56.SetActive(true);

    }
    public void hint2closeClick()
    {

        Destroy(hint56);
        Destroy(button2);

    }
    public void hint3Click()
    {

        hint57.SetActive(true);

    }
    public void hint3closeClick()
    {

        Destroy(hint57);
        Destroy(button3);

    }
}
