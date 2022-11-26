using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dia dialogue;

    public void TriggerDialogue()
    {
        Dialogue obj = FindObjectOfType<Dialogue>();
        obj.gameObject.SetActive(true);
        obj.StartDialogue(dialogue);
    }
}
