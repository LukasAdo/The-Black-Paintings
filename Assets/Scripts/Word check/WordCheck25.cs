using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordCheck25 : MonoBehaviour
{
    public GameObject question25;
    public AudioSource question25Audio;
    public GameObject hint73;
    public GameObject hint74;
    public GameObject hint75;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    // Start is called before the first frame update
    public Button submitAnswerBtn; // assign a UI button object in editor
    public InputField answerInput; // assign a UI inputfield object in editor
    public string a1_right_answer = "Freedom"; // make it public and edit the answer in editor if you like


    public void Awake()
    {
        // add event listener when button for submitting answer is clicked
        submitAnswerBtn.onClick.AddListener(() =>
        {
            // validate the answer
            if (answerInput.text == a1_right_answer)
            {
                // success
                question25Audio.Play();
                Debug.Log("Correct");
                Destroy(question25);
                Application.LoadLevel(2);

            }
            else
            {
                Debug.Log("Wrong");
            }

        });

    }
    public void hint1Click()
    {

        hint73.SetActive(true);

    }
    public void hint1closeClick()
    {

        Destroy(hint73);
        Destroy(button1);

    }
    public void hint2Click()
    {

        hint74.SetActive(true);

    }
    public void hint2closeClick()
    {

        Destroy(hint74);
        Destroy(button2);

    }
    public void hint3Click()
    {

        hint75.SetActive(true);

    }
    public void hint3closeClick()
    {

        Destroy(hint75);
        Destroy(button3);

    }
    
}