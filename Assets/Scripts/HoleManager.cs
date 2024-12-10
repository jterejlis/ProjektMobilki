using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleManager : MonoBehaviour
{
    [SerializeField]
    private GameObject almostHole;
    private float randomX;
    private float randomY;
    void Awake(){
        for(int i=0; i<5; i++){
            Instantiate(almostHole, new Vector2(Random.Range(-20.0f, 20.0f),Random.Range(-10.0f, 10.0f)),Quaternion.identity);
        }
        Invoke("newHole", 10f);
    }

    void newHole(){
        Instantiate(almostHole, new Vector2(Random.Range(-20.0f, 20.0f),Random.Range(-10.0f, 10.0f)),Quaternion.identity);
        Invoke("newHole", 2f);
    }

}
