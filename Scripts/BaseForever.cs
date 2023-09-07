using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseForever : MonoBehaviour
{
    public GameObject player;
    public Vector3 pos = new Vector3(0, 0, -10);
    public Transform camera;
    // Start is called before the first frame update
    void Start()
    {
        camera = GetComponent<Transform>();
    }

    // CameraDrive
    void Update()
    {
        pos.x = player.transform.position.x + 1.5f;
        pos.y = 0;
        pos.z = -10;
        camera.transform.position = pos;
    }
   
}
