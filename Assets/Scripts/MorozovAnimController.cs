using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class MorozovAnimController : MonoBehaviour
{
    public Animator Animator;
    public Rigidbody2D Rigidbody;
    public AIPath aiPath;

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
}
