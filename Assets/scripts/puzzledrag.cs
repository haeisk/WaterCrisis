    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class puzzledrag : MonoBehaviour , IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{       


    private  RectTransform _rectTrans;
    public Canvas myCanvas;
    public int id ;
    private CanvasGroup _canvasGroup;

    private Vector2 initPos;

     private void Start() {
        initPos=transform.position;    
        _canvasGroup = GetComponent<CanvasGroup>();
        _rectTrans = GetComponent<RectTransform>();
    }

    public void OnBeginDrag(PointerEventData  eventData  ){
         Debug.Log("Begin Drag");
         _canvasGroup.blocksRaycasts = false;
    }
    public void OnPointerDown(PointerEventData  eventData  ){
        Debug.Log("Click");
    }
    
    public void OnEndDrag(PointerEventData  eventData  ){
         Debug.Log("End Drag");
          _canvasGroup.blocksRaycasts = true;
    }

  public void OnDrag (PointerEventData  eventData  ){
         Debug.Log("OnDrag");
    _rectTrans.anchoredPosition += eventData.delta/myCanvas.scaleFactor;


    }


    public void  Resetposition() {
        transform.position = initPos;
    }


}
