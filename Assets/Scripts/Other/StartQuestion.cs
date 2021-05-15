using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartQuestion : MonoBehaviour
{
    public GameObject button;
    public GameObject convobutton;
    public GameObject question1;
    

    public void CreditonClick()
    {
        question1.SetActive(true);
        
        button.SetActive(false);
        convobutton.SetActive(false);
    }
    public void ButtononClick()
    {
        question1.SetActive(false);
        
        button.SetActive(true);
        convobutton.SetActive(false);
    }
}