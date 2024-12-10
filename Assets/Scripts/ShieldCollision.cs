/* 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldCollision : MonoBehaviour
{
    public GameObject targetToPush;
    public float speed = 3;
    private Vector2 playerPosition;
    private Rigidbody2D EnemyRigidbody;
    private float moveDirectionPushX;
    private float moveDirectionPushY;
    private Vector2 moveDirectionPush;
    private GameObject target;
    public bool IsPushed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
   
    }
        
    

    void OnCollisionStay2D(Collision2D other){

        if(other.gameObject.tag == "Enemy"){
            targetToPush = other.gameObject;
            targetToPush.GetComponent<EnemyMovement>().Push();
        }

            
            
            }
            
    }

 */
 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldCollision : MonoBehaviour
{
    public GameObject targetToPush;
    public float speed = 3;
    private Vector2 playerPosition;
    private Rigidbody2D EnemyRigidbody;
    private float moveDirectionPushX;
    private float moveDirectionPushY;
    private Vector2 moveDirectionPush;
    private GameObject target;
    public bool IsPushed;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("PlayerSquare");
    }

    // Update is called once per frame
    void Update()
    {

        
                   
            
    }
        
    

    void OnCollisionEnter2D(Collision2D other){

        if(other.gameObject.tag == "Enemy"){
            targetToPush = other.gameObject;
            EnemyRigidbody = targetToPush.GetComponent<Rigidbody2D>();
            moveDirectionPushX = EnemyRigidbody.transform.position.x - target.transform.position.x;
            moveDirectionPushY = EnemyRigidbody.transform.position.y - target.transform.position.y;
            moveDirectionPush = new Vector2(moveDirectionPushX,moveDirectionPushY);
            Debug.Log(EnemyRigidbody.transform.position);
            EnemyRigidbody.linearVelocity =moveDirectionPush*5f;
            targetToPush.GetComponent<EnemyMovement>().IsPushed = true;
         

           

        }

            
            
            }
            
    }

