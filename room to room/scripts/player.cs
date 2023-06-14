using Godot;
using System;

public partial class player : CharacterBody2D
{
    private int speed = 125;
    private Vector2 input_vector;

    public override void _Ready()
    {
        GameServer.player = this;
        this.GlobalPosition = GameServer.playerSpawn;
    }

    public override void _PhysicsProcess(double delta)
    {
        input_vector.X = Input.GetActionStrength("right") - Input.GetActionStrength("left");
        input_vector.Y = Input.GetActionStrength("down") - Input.GetActionStrength("up");

        if (input_vector != Vector2.Zero) {
            Velocity = input_vector * speed;
            MoveAndSlide();
        }
    }
}
