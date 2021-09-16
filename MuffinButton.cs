using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class MuffinButton : MonoBehaviour
{
    [SerializeField] private GameManager gameManager = null;

    public void OnMuffinClicked()
    {
        gameManager.OnMuffinButtonClicked();
    }   
}
