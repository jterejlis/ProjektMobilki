using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    // Start is called before the first frame update
    private int Score = 0;
    [SerializeField]
    private Text myText;
    private int LastPoints;
    void Awake(){
      Score = GameObject.Find("Points").GetComponent<PointCounter>().LastPoint();
    }
    // Start is called before the first frame update
    void Start()
    {
      //Score=GameObject.Find(Points).getComponent<PointCounter>().Points;
      //Score = InGamePoints;
      
    }

    // Update is called once per frame
    void Update()
    {
      myText.text = Score.ToString();
    }

}
