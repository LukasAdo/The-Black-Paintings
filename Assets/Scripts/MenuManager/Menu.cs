using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject credit;
    public GameObject about;
   
    // Start is called before the first frame update
    void Start()
    {
        mainMenu.SetActive(true);
        credit.SetActive(false);
        about.SetActive(false);
       

    }
    public void StartGameonClick()
    {
        Application.LoadLevel(1);
    }

    public void CreditonClick()
    {
        credit.SetActive(true);
        mainMenu.SetActive(false);
        about.SetActive(false);
        
    }
    public void AboutonClick()
    {
        about.SetActive(true);
        credit.SetActive(false);
        mainMenu.SetActive(false);
        
    }
    
    public void NoClick()
    {
        mainMenu.SetActive(true);
        credit.SetActive(false);
        about.SetActive(false);
       

    }
    public void ExitButton()
    {
        Application.Quit();
    }
    public void BackButton()
    {
        mainMenu.SetActive(true);
        credit.SetActive(false);
        about.SetActive(false);
        
    }

}
