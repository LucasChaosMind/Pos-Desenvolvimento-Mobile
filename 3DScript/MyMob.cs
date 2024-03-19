using Godot;
using System;

public partial class MyMob : RigidBody2D
{

	public override void _Ready()
	{
		var animatedSprite2D = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
		string[] mobTypes = animatedSprite2D.SpriteFrames.GetAnimationNames();
		animatedSprite2D.Play(mobTypes[GD.Randi() % mobTypes.Length]);
	}
	private void OnVisibleOnScreenNotifier2dScreenExited()
	{
		QueueFree();
	}

}



