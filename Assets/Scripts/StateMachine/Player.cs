using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerStateMachine StateMachine { get; private set; }
    public PlayerIdleState IdleState { get; private set; }
    public PlayerMoveLeftState MoveLeftState { get; private set; }
    public PlayerMoveRightState MoveRightState { get; private set; }
    public Animator Anim { get; private set; }
    public Rigidbody2D Rigidbody { get; private set; }



    public ControlType controlType;
    public enum ControlType { PC, Android }
    public Joystick joystick;
    public float speed;

    private void Awake()
    {
        StateMachine = new PlayerStateMachine();
        IdleState = new PlayerIdleState(this, StateMachine, "idle");
        MoveLeftState = new PlayerMoveLeftState(this, StateMachine, "moveLeft");
        MoveRightState = new PlayerMoveRightState(this, StateMachine, "moveRight");
        if (controlType == ControlType.PC)
        {
            joystick.gameObject.SetActive(false);
        }

    }
    private void Start()
    {
        Anim = GetComponent<Animator>();
        Rigidbody = GetComponent<Rigidbody2D>();
        StateMachine.Initialize(IdleState);
    }
    private void Update()
    {
        StateMachine.CurrentState.LogicUpdate();
    }
    private void FixedUpdate()
    {
        StateMachine.CurrentState.PhysicsUpdate();
    }
}
