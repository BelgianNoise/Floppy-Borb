using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorbScript : MonoBehaviour
{
  public Rigidbody2D rigid;
  private float flapStrength = 25;
  public LogicScript logicScript;
  private bool isAlive = true;

  // Start is called before the first frame update
  void Start()
  {
    rigid.gravityScale = 5;
    logicScript = GameObject.FindGameObjectWithTag("LogicScriptCustomTag").GetComponent<LogicScript>();
  }

  // Update is called once per frame
  void Update()
  {
    // if player presses space, jump
    if (Input.GetKeyDown(KeyCode.Space) && isAlive)
    {
      rigid.velocity = Vector2.up * flapStrength;
    }

    // rigid body looks at the direction it is going
    rigid.SetRotation(Mathf.Lerp(-40, 40, (rigid.velocity.y + 10) / 20));

  }

  private void OnCollisionEnter2D(Collision2D collision)
  {
    if (collision.gameObject.CompareTag("PipeCustomTag") && isAlive)
    {
      handleGameOver();
    }
  }

  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.CompareTag("PipeCustomTag") && isAlive)
    {
      handleGameOver();
    }
  }

  private void handleGameOver()
  {
    logicScript.gameOver();
    isAlive = false;
  }
}
