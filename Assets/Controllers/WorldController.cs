using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldController : MonoBehaviour
{
	public Sprite DirtSprite;
	public Sprite StoneSprite;
	public GameObject WorldBackround;

	World world;

	void Start()
	{
		world = new World();
		world.RandomizeTiles();

		for (int x = 0; x < world.Width; x++)
		{
			for (int y = 0; y < world.Height; y++)
			{
				Tiles tile_data = world.GetTileAt(x, y);

				GameObject tile_go = new GameObject ();

				Camera.main.transform.position = new Vector3 (50, 50, -16);
				WorldBackround.transform.localScale = new Vector3 (1000, 1000, 0);
				WorldBackround.transform.position = new Vector3 (0, 0, 1);
				tile_go.name = "Tile_" + x + "_" + y;
				tile_go.transform.position = new Vector2(tile_data.x, tile_data.y);

				SpriteRenderer tile_sr = tile_go.AddComponent<SpriteRenderer>();

				if (tile_data.Type == Tiles.TileType.Dirt)
				{
					tile_sr.sprite = DirtSprite;
				}
				if (tile_data.Type == Tiles.TileType.Stone)
				{
					tile_sr.sprite = StoneSprite;
				}
			}
		}
	}

	void OnTileTypeChanged(Tiles tile_data, GameObject tile_go)
	{

		if (tile_data.Type == Tiles.TileType.Dirt)
		{
			tile_go.GetComponent<SpriteRenderer> ().sprite = DirtSprite;
		} 
		else if (tile_data.Type == Tiles.TileType.Stone)
		{
			tile_go.GetComponent<SpriteRenderer> ().sprite = StoneSprite;
		}
		else
		{
			Debug.LogError ("OnTileTypeChanged - Unreconized Tile Type");
		}
	}
}

