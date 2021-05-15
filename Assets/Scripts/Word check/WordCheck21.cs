using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordCheck21 : MonoBehaviour
{
    public GameObject question21;
    public GameObject question22;
    public AudioSource question21Audio;
    public GameObject hint61;
    public GameObject hint62;
    public GameObject hint63;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    // Start is called before the first frame update
    public Button submitAnswerBtn; // assign a UI button object in editor
    public InputField answerInput; // assign a UI inputfield object in editor
    public string a1_right_answer = "House of the deaf man"; // make it public and edit the answer in editor if you like


    public void Awake()
    {
        // add event listener when button for submitting answer is clicked
        submitAnswerBtn.onClick.AddListener(() =>
        {
            // validate the answer
            if (answerInput.text == a1_right_answer)
            {
                // success
                question21Audio.Play();
                Debug.Log("Correct");
                Destroy(question21);
                question22.SetActive(true);
            }
            else
            {
                Debug.Log("Wrong");
            }

        });

    }
    public void hint1Click()
    {

        hint61.SetActive(true);

    }
    public void hint1closeClick()
    {

        Destroy(hint61);
        Destroy(button1);

    }
    public void hint2Click()
    {

        hint62.SetActive(true);

    }
    public void hint2closeClick()
    {

        Destroy(hint62);
        Destroy(button2);

    }
    public void hint3Click()
    {

        hint63.SetActive(true);

    }
    public void hint3closeClick()
    {

        Destroy(hint63);
        Destroy(button3);

    }
}
