using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject spawner;
    private float spawnerPositionX;
    private float spawnerPositionY; 
    public GameObject objectToSpawn;
    // Start is called before the first frame update
    void Start()
    {
      spawnerPositionX = transform.position.x;
      spawnerPositionY = transform.position.y;
      newEnemy();
    }

    // Update is called once per frame
    void newEnemy(){
      Instantiate(objectToSpawn, new Vector2(spawnerPositionX, spawnerPositionY), Quaternion.identity);
      Invoke("newEnemy", 10f);
    }
}