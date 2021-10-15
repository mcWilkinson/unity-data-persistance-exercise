using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour {
    Button button;

    private void Start() {
        button = GetComponent<Button>();
        button.onClick.AddListener(startGame);
    }

    private void Update() {
        button.interactable = GameManager.Instance.username.Length > 0;
    }

    private void startGame() {
        SceneManager.LoadScene("main");
    }

}