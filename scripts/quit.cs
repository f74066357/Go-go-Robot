﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class quit : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData e)
    {
        Debug.Log("quit");
        Application.Quit();
    }
}

