using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class watchmovie : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData e)
    {
        int index = SceneManager.GetActiveScene().buildIndex;
        switch (index)
        {
            case 7:
                SceneManager.LoadScene(18);
                break;
            case 8:
                SceneManager.LoadScene(19);
                break;
            case 9:
                SceneManager.LoadScene(20);
                break;
            case 10:
                SceneManager.LoadScene(21);
                break;
            case 11:
                SceneManager.LoadScene(22);
                break;
            case 12:
                SceneManager.LoadScene(23);
                break;
            case 13:
                SceneManager.LoadScene(24);
                break;
            case 14:
                SceneManager.LoadScene(25);
                break;
            case 15:
                SceneManager.LoadScene(26);
                break;
            case 16:
                SceneManager.LoadScene(27);
                break;
            case 17:
                SceneManager.LoadScene(28);
                break;
            case 29:
                SceneManager.LoadScene(30);
                break;
        }
    }

}
