using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public Dialogqueue dialogqueue;

    public void TriggerDialog ()
    {
        FindObjectOfType<DialogManager>().StartDialogqueue(dialogqueue);
    }
}
