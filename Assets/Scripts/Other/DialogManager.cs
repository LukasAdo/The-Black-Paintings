using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogText;
    public Animator animator;

   
   


    private Queue<string> sentences;
    
    
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        
        
    }

    public void StartDialogqueue(Dialogqueue dialogqueue)
    {
        animator.SetBool("isOpen", true);

        Debug.Log("Starting Conversation with " + dialogqueue.name);

        nameText.text = dialogqueue.name;
       
        sentences.Clear();

        foreach (string sentence in dialogqueue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        NextSentence();
       
    }

    public void NextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialog();
            
            return;
            
        }

        string sentence = sentences.Dequeue();
        Debug.Log(sentence);
        StopAllCoroutines();
        StartCoroutine(TypeDialogslow(sentence));
    }

    IEnumerator TypeDialogslow (string sentence)
    {
        dialogText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogText.text += letter;
            yield return null;
        }
        
    }

    void EndDialog()
    {
        Debug.Log("End of Dialog");
        animator.SetBool("isOpen", false);
      
    }
}
