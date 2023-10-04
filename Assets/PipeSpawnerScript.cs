using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    private float spawnRate = 1.5f;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
    }

    private void spawnPipe()
    {
        // Create pipe object
        Instantiate(
            pipe,
            new Vector3(
                transform.position.x,
                Random.Range(transform.position.y - 9, transform.position.y + 9),
                0
            ),
            transform.rotation
        );
    }
}
