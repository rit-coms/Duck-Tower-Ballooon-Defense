using Godot;
using System;
using System.Collections;

public partial class Level : Node2D
{
	// The obstructions within the current level
	ArrayList Obstruction;
	// This determines the start and end location of the map and sets the obstruction path.
	TileMap tileMap;
	// The ducks that the user has
	ArrayList ducks;
	// This object allows you to exchange game currency to add ducks to the game
	Store store;
	// Game currency used in the store
	int Currency;
	// The nest determines the end of the game
	Nest nest;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
