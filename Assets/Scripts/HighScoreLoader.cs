// using System.Collections;
// using System.Collections.Generic;
// using System;
// using System.Linq;
// using System.IO;
// using UnityEngine;
// using TMPro;
// using UnityEngine.UI;


// public class HighScoreLoader : MonoBehaviour
// {
// public Text testtext; 
// string saveFilePath = Application.persistentDataPath + "/HighScores.json";
// [SerializeField] List<ScoreData> saveListScoreData = new List<ScoreData>();
// public void Awake()
// {
//     string loadPlayerData = File.ReadAllText(saveFilePath);
//     ScoreData[] scores = ZVJson.FromJson<ScoreData>(loadPlayerData, true);
//     testtext.text=string.Concat(scores.Select(x => x.ToString()));
    
// }

// }
