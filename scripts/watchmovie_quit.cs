using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class watchmovie_quit : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData e)
    {
        int index = SceneManager.GetActiveScene().buildIndex;
        switch (index)
        {
            case 18:
                SceneManager.LoadScene(7);
                break;
            case 19:
                SceneManager.LoadScene(8);
                break;
            case 20:
                SceneManager.LoadScene(9);
                break;
            case 21:
                SceneManager.LoadScene(10);
                break;
            case 22:
                SceneManager.LoadScene(11);
                break;
            case 23:
                SceneManager.LoadScene(12);
                break;
            case 24:
                SceneManager.LoadScene(13);
                break;
            case 25:
                SceneManager.LoadScene(14);
                break;
            case 26:
                SceneManager.LoadScene(15);
                break;
            case 27:
                SceneManager.LoadScene(16);
                break;
            case 28:
                SceneManager.LoadScene(17);
                break;
            case 30:
                SceneManager.LoadScene(29);
                break;
        }
    }

}
