using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Sprites;
using System.IO;

public class next : MonoBehaviour, IPointerClickHandler
{
    public Image i;
    public bool unlock_pic2;

    public void OnPointerClick(PointerEventData e)
    {
        if(i.sprite.name.Contains("1"))
        {
            Debug.Log("Contains1");
            if (unlock_pic2 == true)
            {
                i.overrideSprite = (Sprite)Resources.Load<Sprite>("2");
                i.sprite.name = "2";
            }
            else
            {
                i.overrideSprite = (Sprite)Resources.Load<Sprite>("2o");
                i.sprite.name = "2o";
            }
           
        }

    }
}
