using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropPanel : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public static DraggableBlock d;
    List<DraggableBlock> cardsOnTabletop = new List<DraggableBlock>();
    List<string> cardsOnTabletopNames = new List<string>();
    List<Transform> Col1 = new List<Transform>();
    List<Transform> Col2 = new List<Transform>();
    List<Transform> Col3 = new List<Transform>();
    List<Transform> Col4 = new List<Transform>();
    List<Transform> Col5 = new List<Transform>();
    List<Transform> Col6 = new List<Transform>();
    List<Transform> Col7 = new List<Transform>();
    List<Transform> Col8 = new List<Transform>();
    List<List<Transform>> columns = new List<List<Transform>>();


    //public Transform A4, A5, A6, B4, B5, B6, C4, C5, C6, D4, D5, D6, E4, E5, E6, F4, F5, F6, G4, G5, G6, H4, H5, H6;

    void Start()
    {
        GameObject gameControl = GameObject.Find("GameControl");
        GameControl gameControlScript = gameControl.GetComponent<GameControl>();

        Col1.Add(gameControlScript.A4);
        Col1.Add(gameControlScript.A5);
        Col1.Add(gameControlScript.A6);

        Col2.Add(gameControlScript.B4);
        Col2.Add(gameControlScript.B5);
        Col2.Add(gameControlScript.B6);

        Col3.Add(gameControlScript.C4);
        Col3.Add(gameControlScript.C5);
        Col3.Add(gameControlScript.C6);

        Col4.Add(gameControlScript.D4);
        Col4.Add(gameControlScript.D5);
        Col4.Add(gameControlScript.D6);

        Col5.Add(gameControlScript.E4);
        Col5.Add(gameControlScript.E5);
        Col5.Add(gameControlScript.E6);

        Col6.Add(gameControlScript.F4);
        Col6.Add(gameControlScript.F5);
        Col6.Add(gameControlScript.F6);

        Col7.Add(gameControlScript.G4);
        Col7.Add(gameControlScript.G5);
        Col7.Add(gameControlScript.G6);

        Col8.Add(gameControlScript.H4);
        Col8.Add(gameControlScript.H5);
        Col8.Add(gameControlScript.H6);

        columns.Add(Col1);
        columns.Add(Col2);
        columns.Add(Col3);
        columns.Add(Col4);
        columns.Add(Col5);
        columns.Add(Col6);
        columns.Add(Col7);
        columns.Add(Col8);

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        // if (d != null)
        // {
        //     d.placeholderParent = this.transform;
        // }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        // if (d != null && d.placeholderParent == this.transform)
        // {
        //     d.placeholderParent = d.parentToReturnTo;
        // }
    }

    public void OnDrop(PointerEventData eventData)
    {
        d = eventData.pointerDrag.GetComponent<DraggableBlock>();
        if (d != null)
        {
            d.parentToReturnTo = this.transform;
        }

        //   StartCoroutine((RegisterWord()));
    }

    // IEnumerator RegisterWord()
    // {
    //     yield return new WaitForSeconds(0.1f);

    //     GameObject gameControl = GameObject.Find("GameControl");
    //     GameControl gameControlScript = gameControl.GetComponent<GameControl>();
    //     gameControlScript.UpdateStage();
    // }
}
