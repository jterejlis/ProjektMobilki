using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    [SerializeField]
    public GameObject PowerUp;
    public GameObject PlayerSquare;
    
    private GameObject spawnedPowerUp;

    private bool isSpawned;
    private bool isSpawnCroutineRunning;
    private float PowerUpDuration = 5.0f;
    private float movementSpeed;
    private float boostedMovementSpeed = 7.0f;
   
    // void Awake()
    // {
    //     for(int i=0; i<5; i++)
    //     {
    //         Instantiate(almostHole, new Vector2(Random.Range(-20.0f, 20.0f),Random.Range(-10.0f, 10.0f)),Quaternion.identity);
    //     }
    //     Invoke("newHole", 10f);
    // }

    // Start is called before the first frame update
    void Start()
    {
        PlayerSquare = GameObject.Find("PlayerSquare");
        movementSpeed = PlayerSquare.GetComponent<PlayerMovement>().movementSpeed;
        isSpawned = false;
    }

    // Update is called once per frame
    void Update()
    {
        

        if(!isSpawned)
        {
            StartCoroutine(SpawnPowerUp());
        }

        else if(isSpawned && !isSpawnCroutineRunning)
        {
            if(Vector2.Distance(spawnedPowerUp.transform.position, PlayerSquare.transform.position) < 0.5)
            {
                Debug.Log(Vector2.Distance(spawnedPowerUp.transform.position, PlayerSquare.transform.position));
                PlayerSquare.GetComponent<PlayerMovement>().movementSpeed=boostedMovementSpeed;
                Destroy(spawnedPowerUp);
                isSpawned = false;
                StartCoroutine(PowerUpEffect(PowerUpDuration));

            }
        }
    }

    IEnumerator SpawnPowerUp()
    {
        isSpawned = true;
        isSpawnCroutineRunning = true;
        yield return new WaitForSeconds(Random.Range(1.0f, 10.0f));
        spawnedPowerUp = Instantiate(PowerUp, new Vector2(Random.Range(-20.0f, 20.0f),Random.Range(-10.0f, 10.0f)),Quaternion.identity);
        isSpawnCroutineRunning = false;
        Debug.Log("PowerUp Spawned!");
    }

    IEnumerator PowerUpEffect(float duration)
    {
        
        yield return new WaitForSeconds(duration);
        Debug.Log("PowerUp run off. Setting previous speed!");
        PlayerSquare.GetComponent<PlayerMovement>().movementSpeed=movementSpeed;

    }
}
