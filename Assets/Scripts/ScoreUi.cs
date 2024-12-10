using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System;
using System.IO;
using TMPro;
using UnityEngine.UI;

public class ScoreUi : MonoBehaviour
{
    public RowUi rowUi;
    public ScoreManager scoreManager;
    public GameObject CanvasParent;
    
    void Start()
    {
        
        //rowUi.gameObject.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height / 2, 10));
        Score temp = new Score();
        temp.name = PlayerPrefs.GetString("tempName", "");
        temp.score = Convert.ToInt32(PlayerPrefs.GetString("tempPoints","-1"));
        PlayerPrefs.DeleteKey("tempName");
        PlayerPrefs.DeleteKey("tempPoints");
        Debug.Log(temp.name);
        if(temp.name != "" && temp.score != -1 )
        {
            scoreManager.AddScore(temp);
        }
        
        var scores = scoreManager.GetHighScores().ToArray();
        for (int i = 0; i < scores.Length; i++)
        {
            // Vector3 vSpawnPos = transform.position;
            // vSpawnPos.y -= 30;
            
            // var row = Instantiate(rowUi, transform.position + Vector3.down * 20, Quaternion.identity).GetComponent<RowUi>();
            var row = Instantiate(rowUi, transform, worldPositionStays:true).GetComponent<RowUi>();
            // var test = this.gameObject.transform.GetChild(i);
            row.rank.text = (i + 1).ToString();
            row.name.text = scores[i].name;
            row.score.text = scores[i].score.ToString();
            row.gameObject.transform.localScale = new Vector3(2.5f,2.5f,2.5f);
            //transform.Translate(0,20,0);
            // transform.Translate(20,0,0);
            transform.position += new Vector3(0,0.5f,0);

        }
        //transform.position += new Vector3(650,-30,0);
    }
}