using Godot;
using System;

public abstract class OnGround : Motion
{
    public override string HandlePhysics(float delta)
    {
        // Base here will be Motion, which will always return null
        string move = base.HandlePhysics(delta);
        if(host.IsOnFloor() && Input.IsActionPressed("Jump"))
            return "Jump";
        return move;
    }

    //Normal Attack
    protected override void Attack()
    {    
        host.Attack(0);
    }
    
}