using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Element : MonoBehaviour 
{
	#region Variables

	public Sprite[] emptyTextures;
	public Sprite mineTexture;

	// either a mine or not
	public bool mine;

	#endregion

	private void Start() 
	{
		// Randomly decide if it's a mine or not
//		mine = Random.value < 0.15;

		// TEST
		LoadTexture(1);

		
	}

	public void LoadTexture(int adjacentCount)
	{
		if(mine)
		{
			// checks if the sprite is a texture or not.
			GetComponent<SpriteRenderer>().sprite = mineTexture;
		}
		else
		{
			// else renders one of the empty texutures.
			GetComponent<SpriteRenderer>().sprite = emptyTextures[adjacentCount];
		}
	}




} // main class
