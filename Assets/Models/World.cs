using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World
{
	Tiles[,] tiles;
	int width;

	public int Width
	{
		get
		{
			return width;
		}
	}

	int height;

	public int Height
	{
		get
		{
			return height;
		}
	}
	int maxnumber = 1980000;

	public World(int width = 150, int height = 150)
	{
		this.width = width;
		this.height = height;

		tiles = new Tiles[width, height];

		for (int x = 0; x < width; x++)
		{
			for (int y = 0; y < height; y++)
			{
				tiles [x, y] = new Tiles (this, x, y);
			}	
		}

		Debug.Log ("World created with " + (width*height) + " tiles.");
	}

	public void RandomizeTiles()
	{
		for (int x = 0; x < width; x++)
		{
			for (int y = 0; y < height; y++)
			{
				if (Random.Range (0, 2) == 0)
				{
					tiles [x, y].Type = Tiles.TileType.Dirt;
				}
				else
				{
					tiles [x, y].Type = Tiles.TileType.Stone;

				}
			}
		}
	}

	public Tiles GetTileAt(int x, int y)
	{
		if (x > width || x < 0 || y > height || y < 0)
		{
			Debug.LogError ("Tile (" + x + ", " + y + ") is out of range. ");
			return null;
		}
		return tiles [x, y];
	}

	public int GetWidth()
	{
		return width;
	}
}