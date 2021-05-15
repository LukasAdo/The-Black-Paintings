using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backgroundlogic : MonoBehaviour
{
    public GameObject Backgroundimg1;
    public GameObject Backgroundimg2;


    public void onClick()
    {
        Backgroundimg1.SetActive(true);
        Backgroundimg2.SetActive(false); 
    }
    public void ButtononClick()
    {
        Backgroundimg1.SetActive(false);
        Backgroundimg2.SetActive(true);
    }
}
