using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public DialogueManager dialogueManager;

   public void Start() {
        // Create a new list to store the dialogue options
        StartDialogue();
    }
    public Message[] messages;
    public Actor[] actors;
     public void nexxtMessage(){
    dialogueManager.NextMessage();
    }

    public void StartDialogue(){
        FindObjectOfType<DialogueManager>().OpenDialogue(messages,actors);
    }
}
   
[System.Serializable]
public class Message {
    public int actorId ;
    public string message;

}

[System.Serializable]
public class Actor{
    public string name;
    public Sprite sprite;
}