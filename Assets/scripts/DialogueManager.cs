using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{

    public Image actorImage;
    public Text actorName;
    public Text messageText;
    public RectTransform backgroundBox;
public static bool isActive = false;
    Message[] currentMessage;
    Actor[] currentActors;
    int activeMessage = 0;

    // Start is called before the first frame update
    void Start()
    {   
      DisplayMessage();
    }
    public void OpenDialogue(Message[] messages, Actor[] actors){
        currentActors= actors;
        currentMessage= messages;
        activeMessage = 0;
        isActive=true;
        Debug.Log("started conversation! loaded messages;"+messages.Length);
        DisplayMessage();

    }

    void DisplayMessage (){
        Message messageToDisplay = currentMessage[activeMessage];
        messageText.text = messageToDisplay.message;

    Actor actorToDisplay = currentActors[messageToDisplay.actorId];
    actorName.text = actorToDisplay.name;
    actorImage.sprite = actorToDisplay.sprite;
    }

    public void NextMessage(){
        activeMessage++;
        if(activeMessage < currentMessage.Length){
            DisplayMessage();
        }else
        {
            Debug.Log("conversation ended");
            backgroundBox.LeanScale(Vector3.zero,0.5f).setEaseInOutExpo();
            isActive= false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&isActive==true)
        {
            NextMessage();
        }
    }
}
