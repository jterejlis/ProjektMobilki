using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleCreator : MonoBehaviour
{
    [SerializeField]
    private GameObject objectToSpawn;
    void Start()
    {
        Invoke("createfirsthole", 3f);
    }

    void createfirsthole(){
        Instantiate(objectToSpawn, this.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    //public void createmorehole{

 //   }
}
