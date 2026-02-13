using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigCloudSpawnerScript : MonoBehaviour
{
    public GameObject BigCloud;
    public float spawn_rate = 5;
    private float timer = 0;
    public float height_offset = 7;
    // Start is called before the first frame update
    void Start()
    {
        spawn_cloud();
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
            spawn_cloud();
            timer = 0;
        }
    }

    void spawn_cloud()
    {
        float lowest_point = transform.position.y - height_offset;
        float highest_point = transform.position.y + height_offset;
        Instantiate(BigCloud, new Vector3(transform.position.x, Random.Range(lowest_point, highest_point), 0), transform.rotation);
    }
}
