using Godot;
using System;

public partial class player : Node3D
{
	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (Input.IsActionPressed("ui_accept"))
		{
			Position += new Vector3(0, (float)delta, 0);
		}

		if (Input.IsActionPressed("ui_left"))
		{
			RotateZ((float)delta);
		}

		if (Input.IsActionPressed("ui_right"))
		{
			RotateZ(-(float)delta);
		}	
	}
}
