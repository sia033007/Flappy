using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System;

public class MainUI : MonoBehaviour
{
    public Text userDisplay;
    public Text scoreDisplay;
    public Text levelDisplay;

    private void Awake() {
        userDisplay.text = DBManager.username;
        scoreDisplay.text =""+DBManager.coin;
        levelDisplay.text = ""+DBManager.level;
    }
}
