using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
    public GameObject mainMenu;

    void Start()
    {
        mainMenu.SetActive(true);
        

    }
    public void BacktoGameMenuonClick()
    {
        Application.LoadLevel(0);
    }
}
