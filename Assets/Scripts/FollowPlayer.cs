using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("PlayerSquare");
    }

    // Update is called once per frame
    void Update()
    {
         transform.position = new Vector3 (player.transform.position.x ,player.transform.position.y , -10);
    }
}
