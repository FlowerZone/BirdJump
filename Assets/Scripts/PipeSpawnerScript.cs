using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawn_rate = 2;
    private float timer = 0;
    public float height_offset = 10;
    // Start is called before the first frame update
    void Start()
    {
        spawn_pipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawn_rate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawn_pipe();
            timer = 0;
        }
        
    }
    void spawn_pipe()
    {
        float lowest_point = transform.position.y - height_offset;
        float highest_point = transform.position.y + height_offset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowest_point, highest_point), 0), transform.rotation);
    }
}
