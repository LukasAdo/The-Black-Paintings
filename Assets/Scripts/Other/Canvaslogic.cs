using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvaslogic : MonoBehaviour
     
{
    public GameObject dialog;
    public GameObject question;
// Start is called before the first frame update
void Start()
    {
        dialog.SetActive(true);
        question.SetActive(false);
    }

    public void StartGameonClick()
    {
        dialog.SetActive(false);
        question.SetActive(true);
    }
}