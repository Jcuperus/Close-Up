﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StartButtonBehaviour : MonoBehaviour {
    void Awake() {
        UIManager uiManagerScript = (UIManager)GameObject.Find("Managers").GetComponent(typeof(UIManager));
        NetworkClientManager clientManager = (NetworkClientManager)GameObject.Find("Managers").GetComponent(typeof(NetworkClientManager));
        Button joinButton = GameObject.Find("StartButton").GetComponent<Button>();
        joinButton.onClick.AddListener(uiManagerScript.handleStart);
        this.gameObject.SetActive(clientManager.getIsHost());

        UIManager uiManager = (UIManager)GameObject.Find("Managers").GetComponent(typeof(UIManager));
        uiManager.setStartButton(this.gameObject.GetComponent<Button>());
    }
}
