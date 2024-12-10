/* using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour
{
    private GameObject target;
    public float speed;
    private Vector2 targetPosition;
    private Rigidbody2D EnemyRigidbody;
   
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("PlayerSquare");
        EnemyRigidbody = GetComponent<Rigidbody2D>();
        Move();
    }

    // Update is called once per frame
    void Update()
    {
        
       Move();
    }

    public void  Move(){
        targetPosition = target.transform.position;
        transform.position = Vector2.MoveTowards(transform.position, targetPosition ,(speed*Time.deltaTime));
    }
    public void stop(){
            EnemyRigidbody.velocity = new Vector2(0,0);
    }

    void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.name == "PlayerSquare"){
            GameObject.Find("GameManager").GetComponent<gameManager>().GameOver();
        }
        if(other.gameObject.tag == "Enemy"){
            stop();
        }
    }


    public void Push(){
        }
}

 */
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour
{
    private GameObject target;
    public float speed;
    private Vector2 targetPosition;
    private Rigidbody2D EnemyRigidbody;
    public bool IsPushed = false;
  
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("PlayerSquare");
        EnemyRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void FixedUpdate(){
        
        if(IsPushed == true){
           Invoke ("stop", .3f);
           IsPushed = false;
       }

       Move(); 
    }

    public void  Move(){
        targetPosition = target.transform.position;
        transform.position = Vector2.MoveTowards(transform.position, targetPosition ,speed*Time.deltaTime);
    
    }
    public void stop(){
            EnemyRigidbody.linearVelocity = new Vector2(0,0);
            Debug.Log("stoped");
    }

    void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.tag == "Player"){
                GameObject.Find("GameManager").GetComponent<gameManager>().GameOver();

            }
        if(other.gameObject.tag == "Enemy"){
            stop();
            IsPushed = false;

        }
    }
}
