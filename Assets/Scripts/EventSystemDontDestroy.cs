using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSystemDontDestroy : MonoBehaviour
{
    static bool exist = false;
    void Awake(){
        if(!exist){
            DontDestroyOnLoad (this.gameObject);
            exist = true;
        }
        else{
            Destroy(this.gameObject);
        }

    }
}
