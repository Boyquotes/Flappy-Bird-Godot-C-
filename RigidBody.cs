using Godot;
using System;

public partial class RigidBody : RigidBody2D
{
    private readonly float _gravity = 1;
    public override void _PhysicsProcess(double delta)
    {
        var collision = MoveAndCollide(new Vector2(0, _gravity));

        if (collision != null)
        {
            GD.Print("collision!");
            GetTree().ChangeSceneToFile("res://lost.tscn");
        }

    }

    public override void _UnhandledInput(InputEvent @event)
    {
        if (@event is InputEventKey eventKey)
        {
            if (eventKey.Pressed && eventKey.Keycode == Key.Space)
            {
                LinearVelocity = new Vector2(0, -400);
                GD.Print(LinearVelocity);
            }
        }
    }

}