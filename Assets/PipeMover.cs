using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMover : MonoBehaviour
{
  private float moveSpeed = 15;
  // Start is called before the first frame update
  void Start()
  {
    
  }

  // Update is called once per frame
  void Update()
  {
    transform.position += Vector3.left * moveSpeed * Time.deltaTime;
    if (transform.position.x < -45)
    {
        Debug.Log("Destroying pipe");
        Destroy(gameObject);
    }
  }
}
