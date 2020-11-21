using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public Transform player;
    private Vector2 camBounds = new Vector2( 5,5);
    // Start is called before the first frame update
    void Start()
    {
        print(Camera.main.pixelHeight);

    }

    // Update is called once per frame
    void Update()
    {
     
        

        if (player.transform.position.x > transform.position.x)
        {
            transform.position = new Vector2(camBounds.x * -1, camBounds.y * -1);

        }
       
    }
}
