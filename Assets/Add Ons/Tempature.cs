using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tempature : MonoBehaviour
{
	public int fahrenheit;
	public int F;
	public bool sunny;
	public bool hot;
	public bool heatwave;
	public bool cold;
	public bool snow;
	public bool blizard;
	public bool hail;
	public bool winter;
	public bool spring;
	public bool fall;
	public bool summer;
	public float W_event;
	public static int x;
	public static int y;

	void Start ()
	{	
		Random.Range (0, 100);
	}

	void Update ()
	{
		Tempature.x = Random.Range;
		Tempature.y = Random.Range; 
		fahrenheit = F;
		if (summer == true)
		{
			if (85 > W_event)
			{
				if (sunny == true)
				{
					Random.Range (70, 89);
				}
			}
			if (10 > W_event)
			{
				if (hot == true)
				{
					Random.Range (90, 105);
				}
			}
			if (5 > W_event)
			{
				if (heatwave == true)
				{
					Random.Range (106, 120);
				}
			}
		}

		if (winter == true)
		{
			if (85 > W_event)
			{	
				if (cold == true)
				{
					Random.Range (29, 50);
				}
			}
			if (10 > W_event)
			{	
				if (snow == true)
				{
					Random.Range (11, 28);
				}
			}
			if (5 > W_event)
			{
				if (blizard == true)
				{
					Random.Range (11, 28);
				}
			}
			if (5 > W_event)
			{	
				if (hail == true)
				{
					Random.Range (0, 11);
				}
			}	
		}
		Debug.Log (Random.Range(x, y));
	}
}
