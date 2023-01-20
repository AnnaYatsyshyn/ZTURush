using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Pathfinding;

public class MorozovController : MonoBehaviour
{
    public Animator Animator;
    public Rigidbody2D Rigidbody;
    public AIPath aiPath;
    public Transform[] points;

    void Start()
    {
        Animator = GetComponent<Animator>();
        Rigidbody = GetComponent<Rigidbody2D>();
        aiPath = GetComponentInParent<AIPath>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (aiPath.desiredVelocity.x <= 0.01f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        } else if (aiPath.desiredVelocity.x >= -0.01f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "Player") {
            GameObject Player = collision.gameObject;
            transform.parent.transform.position = points[Random.Range(0, points.Length - 1)].position;
            Player.transform.position = Player.GetComponent<Player>().startPoint;
            HealthController health = Player.GetComponent<HealthController>();
            Player.GetComponent<HealthController>().health--;
            if (Player.GetComponent<HealthController>().health <=0 )
            {
                SceneManager.LoadScene(1);
            }
        }
    }
}


