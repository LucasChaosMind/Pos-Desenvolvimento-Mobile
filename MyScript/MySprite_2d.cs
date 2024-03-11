using Godot;
using System;

public partial class MySprite_2d : Sprite2D
{	
	private int _speed =400;
	
	private float _angularSpeed = Mathf.Pi;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		 var timer = GetNode<Timer>("Timer");
	   	 timer.Timeout += OnTimerTimeout;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		public float speed = 50.0f;   // Public for editor adjustment

		private float _horizontal;
		private float _vertical;

	public override void _Process(float delta)
	{
		_horizontal = Input.GetActionStrength("ui_right") - Input.GetActionStrength("ui_left");
		_vertical = Input.GetActionStrength("ui_up") - Input.GetActionStrength("ui_down");

		Vector2 movement = new Vector2(_horizontal, _vertical).Normalized() * speed * delta;
		MoveAndSlide(movement);
	}
	private void _On_Button_Pressed() {
		SetProcess(!IsProcessing());
	}
	
 	private void OnTimerTimeout() { 
		/*Visible = !Visible;*/
	}
}

   

  

  



