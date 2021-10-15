using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NameInput : MonoBehaviour {
    TMP_InputField inputField;
    private void Start() {
        inputField = GetComponent<TMP_InputField>();
        inputField.onEndEdit.AddListener(updateName);
    }

    public void updateName(string newName) {
        GameManager.Instance.username = newName;
    }

}
