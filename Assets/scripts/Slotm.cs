using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slotm : MonoBehaviour , IDropHandler
{
    public int id;
   public void OnDrop(PointerEventData  eventData  ){
         Debug.Log("item droped");

        if(eventData.pointerDrag != null  ) {
            if(eventData.pointerDrag.GetComponent<puzzledrag>().id == id){
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = this.GetComponent<RectTransform>().anchoredPosition;

                Debug.Log("correct");

            } else{
                eventData.pointerDrag.GetComponent<puzzledrag>( ).Resetposition();
            }
            
        }

    }


}
