using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DraggableBlock : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Transform parentToReturnTo = null;
    public Transform placeholderParent = null;
    //  GameObject placeholder = null;

    //  public AudioClip audioClip;


    public void OnBeginDrag(PointerEventData eventData)
    {
        parentToReturnTo = this.transform.parent;
        placeholderParent = parentToReturnTo;
        this.transform.SetParent(this.transform.parent.parent);

        //  print(this.name);
        RectTransform rt = this.GetComponent<RectTransform>();
        rt.sizeDelta = new Vector2(90, 90);

        GetComponent<CanvasGroup>().blocksRaycasts = false;

        StartCoroutine((RegisterWord()));
    }

    public void OnDrag(PointerEventData eventData)
    {
        //  Debug.Log("dragging");

        this.transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        this.transform.SetParent(parentToReturnTo);

        GetComponent<CanvasGroup>().blocksRaycasts = true;

        // Destroy(placeholder);

        StartCoroutine((RegisterWord()));
    }


    IEnumerator RegisterWord()
    {
        yield return new WaitForSeconds(0.1f);

        GameObject gameControl = GameObject.Find("GameControl");
        GameControl gameControlScript = gameControl.GetComponent<GameControl>();
        gameControlScript.UpdateStage();
    }





}
