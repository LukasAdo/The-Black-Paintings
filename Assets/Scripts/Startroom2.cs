using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Startroom2 : MonoBehaviour
{
    public GameObject transfer;
    public GameObject question6;
    public Button submitAnswerBtn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Awake()
    {
        // add event listener when button for submitting answer is clicked
        submitAnswerBtn.onClick.AddListener(() =>
        {
            
            {
                // success
                
                Debug.Log("Correct");
                Destroy(transfer);
                question6.SetActive(true);
            }
            

        });

    }
}
