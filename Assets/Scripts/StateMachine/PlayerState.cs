using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState
{
    protected Player player;
    protected PlayerStateMachine stateMachine;

    protected float startTime;

    private string animBoolName;
    protected Vector2 input;
    protected Vector2 velocity;

    public PlayerState(Player player, PlayerStateMachine stateMachine, string animBoolName)
    {
        this.player = player;
        this.stateMachine = stateMachine;
        this.animBoolName = animBoolName;
    }

    public virtual void Enter()
    {
        DoChecks();
        player.Anim.SetBool(animBoolName, true);
        startTime = Time.time;
        Debug.Log(animBoolName);
    }

    public virtual void Exit()
    {
        player.Anim.SetBool(animBoolName, false);
    }

    public virtual void LogicUpdate()
    {
        if (player.controlType == Player.ControlType.PC)
        {
            input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        }
        else if (player.controlType == Player.ControlType.Android)
        {
            input = new Vector2(player.joystick.Horizontal, player.joystick.Vertical);
        }
    }

    public virtual void PhysicsUpdate()
    {
        DoChecks();
        velocity = input.normalized * player.speed;
        player.Rigidbody.MovePosition(player.Rigidbody.position + velocity * Time.fixedDeltaTime);
    }
    public virtual void DoChecks()
    {

    }
}
