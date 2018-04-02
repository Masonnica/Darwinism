using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiles
{
	public enum TileType { Dirt, Stone, Sand};

	public TileType Type = TileType.Dirt;
	LooseObject LooseObject;
	InstalledObject InstalledObject;
	World World;
	public int x;

	public int X
	{
		get
		{
			return x;
		}
	}
	public int y;
	public int Y
	{
		get
		{
			return y;
		}
	}

	public Tiles( World world, int x, int y )
	{
	this.World = world;
	this.x = x;
	this.y = y;
	}
}