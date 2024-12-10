using System.Collections;
using System.Collections.Generic;
using TouchControlsKit;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float RotateSpeed;
    public TCKButton left;
    public TCKButton rigth;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("PlayerSquare");
    }

    // Update is called once per frame
    void Update()
    {
        if (left.isPRESSED)
        {
            transform.Rotate(Vector3.forward * RotateSpeed);
        }
        
        if (rigth.isPRESSED)
        {
            transform.Rotate(Vector3.forward * -RotateSpeed);
        }

        transform.position= player.transform.position; 
    }
}
