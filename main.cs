using Godot;
using System;

public partial class main : Node2D
{
    private ParallaxBackground _parallaxBackground;
    private AnimationPlayer _animationPlayer;
    public override void _Ready()
	{
		GD.Print("Ready!");
        InitNode();
	}

    private void InitNode()
    {
        _parallaxBackground = GetNode<ParallaxBackground>("ParallaxBackground");
        _animationPlayer = GetNode<AnimationPlayer>("Player");
    }

	public override void _Process(double delta)
	{
	}



}
