using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveRightState : PlayerState
{
    public PlayerMoveRightState(Player player, PlayerStateMachine stateMachine, string animBoolName) : base(player, stateMachine, animBoolName)
    {
    }

    public override void DoChecks()
    {
        base.DoChecks();
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();
        if (input.x == 0f)
        {
            stateMachine.ChangeState(player.IdleState);
        }
        else if (input.x < 0f)
        {
            stateMachine.ChangeState(player.MoveLeftState);
        }
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}