using UnityEngine;

public class CameraController : MonoBehaviour
{

    GameObject player;
    Vector3 offset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //player = GameObject.Find("Car");
        player = GameObject.FindWithTag("Player");
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       transform.position =  player.transform.position + offset;
    }
}
