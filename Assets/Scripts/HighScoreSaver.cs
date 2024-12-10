using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;
using System.IO;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
// using static ScoreManager;


public class HighScoreSaver : MonoBehaviour
{

    [SerializeField] TMP_InputField userName;
    [SerializeField] public Text points;
    // public GameObject UserInput;
    // private ScoreManager scoreManager;
    Score playerScore;
    string saveFilePath;
    // private ScoreData scoreData = new ScoreData();

    // 
    public void SaveHighScore()
    {
        // playerScore = new Score();
        PlayerPrefs.SetString("tempName",userName.text);
        PlayerPrefs.SetString("tempPoints",points.text);
       
        //scoreManager.AddScore(playerScore);
        
        // saveFilePath = Application.persistentDataPath + "/HighScores.json";

        // string saveScoreData = JsonUtility.ToJson(scoreData);
        // File.AppendAllText(saveFilePath, saveScoreData);

        // Nie wiem, w Pythonie jest to latwiejsze 
        // saveListScoreData.Add(scoreData);
        // ScoreData[] arrayScoreData = saveListScoreData.ToArray();

        // string jsonScoreData = ZVJson.ToJson(arrayScoreData);
        
        // Debug.Log(jsonScoreData);

        // PlayerPrefs.SetString("ScoreData",jsonToSave);
        // PlayerPrefs.Save();

        // string jsonToLoad = PlayerPrefs.GetString("ScoreData");
        // //Load as Array
        // ScoreData[] _tempLoadListData = JsonHelper.GetJsonObject(jsonToLoad);
        // //Convert to List
        // List<ScoreData> loadListData = _tempLoadListData.OfType<ScoreData>().ToList();
        // for (int i = 0; i < loadListData.Count; i++)
        // {
        //     Debug.Log("Got: " + loadListData[i].Name + loadListData[i].Points.ToString());
        // }

        //Debug.Log(PlayerPrefs.GetString("ScoreData"))
    }

    public void DeleteKeys()
    {
        if(userName.text=="CLEARHS")
        {
            PlayerPrefs.DeleteAll();
        }
    }
}
