using Godot;
using System;

public partial class player : Node3D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GD.Print("Hello World!");
		GD.Print("Don't panic");
		GD.Print("42");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (Input.IsActionPressed("ui_accept"))
		{

		}
	}
}
