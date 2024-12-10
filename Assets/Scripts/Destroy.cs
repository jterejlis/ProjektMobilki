using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroy : MonoBehaviour
{   
    
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
    }

  void OnTriggerEnter2D(Collider2D other)
 {
     
     if(other.gameObject.tag == "Enemy"){
        Destroy(other.gameObject);
        GameObject.Find("Points").GetComponent<PointCounter>().Points++;
    }

     if(other.gameObject.tag == "Player"){
        GameObject.Find("GameManager").GetComponent<gameManager>().GameOver();
     }
    
 }

}
