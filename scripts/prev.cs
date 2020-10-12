using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Sprites;


public class prev : MonoBehaviour, IPointerClickHandler
{
    public Image i;

    public bool unlock_pic1;
public void OnPointerClick(PointerEventData e)
{
    if (i.sprite.name.Contains("2"))
    {
        Debug.Log("Contains2");
            if (unlock_pic1 == true)
            {
                i.overrideSprite = (Sprite)Resources.Load<Sprite>("1");
                i.sprite.name = "1";
            }
            else
            {
                i.overrideSprite = (Sprite)Resources.Load<Sprite>("1o");
                i.sprite.name = "1o";
            }
    }

}
}
