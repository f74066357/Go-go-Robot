using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Sprites;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;



public class unlock1 : MonoBehaviour, IPointerClickHandler
{

    public Image i;
    public void OnPointerClick(PointerEventData e)
    {
        Debug.Log("unlock!!!");
        if (i.sprite.name == "1o")
        {
            Debug.Log("1o");
            i.overrideSprite = (Sprite)Resources.Load<Sprite>("1");
            i.sprite.name = "1";
        }
        if (i.sprite.name == "2o")
        {
            Debug.Log("2o");
            i.overrideSprite = (Sprite)Resources.Load<Sprite>("2");
            i.sprite.name = "2";

        }
    }
}