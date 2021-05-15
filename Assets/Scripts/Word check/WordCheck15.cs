using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordCheck15 : MonoBehaviour
{
    public GameObject question15;
    public GameObject question16;
    public GameObject Room4;
    public AudioSource question15Audio;
    public GameObject hint43;
    public GameObject hint44;
    public GameObject hint45;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject bgimage3;
    public GameObject bgimage4;
    // Start is called before the first frame update
    public Button submitAnswerBtn; // assign a UI button object in editor
    public InputField answerInput; // assign a UI inputfield object in editor
    public string a1_right_answer = "Ferdinand VII"; // make it public and edit the answer in editor if you like


    public void Awake()
    {
        // add event listener when button for submitting answer is clicked
        submitAnswerBtn.onClick.AddListener(() =>
        {
            // validate the answer
            if (answerInput.text == a1_right_answer)
            {
                // success
                
                Debug.Log("Correct");
                Destroy(question15);
                Room4.SetActive(true);
                Destroy(bgimage3);
                bgimage4.SetActive(true);
            }
            else
            {
                Debug.Log("Wrong");
            }

        });

    }
    public void onClick()
    {
        Destroy(Room4);
        question15Audio.Play();
        question16.SetActive(true);

    }
    public void hint1Click()
    {

        hint43.SetActive(true);

    }
    public void hint1closeClick()
    {

        Destroy(hint43);
        Destroy(button1);

    }
    public void hint2Click()
    {

        hint44.SetActive(true);

    }
    public void hint2closeClick()
    {

        Destroy(hint44);
        Destroy(button2);

    }
    public void hint3Click()
    {

        hint45.SetActive(true);

    }
    public void hint3closeClick()
    {

        Destroy(hint45);
        Destroy(button3);

    }
}