using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointCounter : MonoBehaviour
{
    public int Points = 0;
    public Text myText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      myText.text = Points.ToString();
    }
    //public int Points{get;};
    public int LastPoint(){
      return Points;
    }
}
