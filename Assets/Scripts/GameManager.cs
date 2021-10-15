using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public static GameManager Instance;

    public HighScoreData highscore;
    public string username;

    private void Awake() {
        if(Instance != null) {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Start() {
        LoadHighScore();
    }

    [Serializable]
    public class HighScoreData {
        public int highScore;
        public string name;
    }

    public void SaveHighScore() {
        string path = Application.persistentDataPath + "/savefile.json";
        string json = JsonUtility.ToJson(highscore);

        File.WriteAllText(path, json);
    }

    public void LoadHighScore() {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path)) {
            string json = File.ReadAllText(path);
            HighScoreData data = JsonUtility.FromJson<HighScoreData>(json);

            highscore = data;
        }
    }

    public void updateName(string name) {
        username = name;
    }
}