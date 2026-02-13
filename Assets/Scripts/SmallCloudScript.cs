using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallCloudScript : MonoBehaviour
{
    public float move_speed = 2;
    public float dead_zone = -40;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + ((Vector3.left * move_speed) * Time.deltaTime);
        if(transform.position.x < dead_zone)
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }
    }
}
