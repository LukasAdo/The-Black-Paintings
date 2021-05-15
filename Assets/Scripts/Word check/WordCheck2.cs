using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordCheck2 : MonoBehaviour
{
    public GameObject question2;
    public GameObject question3;
    public AudioSource question2Audio;
    public GameObject hint4;
    public GameObject hint5;
    public GameObject hint6;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    // Start is called before the first frame update
    public Button submitAnswerBtn; // assign a UI button object in editor
    public InputField answerInput; // assign a UI inputfield object in editor
    public string a1_right_answer = "José Benito de Goya y Franque"; // make it public and edit the answer in editor if you like
    

    public void Awake()
    {

        
        
        // add event listener when button for submitting answer is clicked
        submitAnswerBtn.onClick.AddListener(() =>
        {
            // validate the answer
            if (answerInput.text == a1_right_answer)
            {
                // success
                question2Audio.Play();
                Debug.Log("Correct");
                Destroy(question2);
                question3.SetActive(true);
            }
            else
            {
                Debug.Log("Wrong");
            }

        });

    }
    public void hint1Click()
    {

        hint4.SetActive(true);

    }
    public void hint1closeClick()
    {

        Destroy(hint4);
        Destroy(button1);

    }
    public void hint2Click()
    {

        hint5.SetActive(true);

    }
    public void hint2closeClick()
    {

        Destroy(hint5);
        Destroy(button2);

    }
    public void hint3Click()
    {

        hint6.SetActive(true);

    }
    public void hint3closeClick()
    {

        Destroy(hint6);
        Destroy(button3);

    }
}
