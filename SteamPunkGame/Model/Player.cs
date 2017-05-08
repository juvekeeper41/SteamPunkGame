using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SteamPunkGame.Model
{
	public class Player
	{
		// Animation representing the player
		public Animation PlayerAnimation;

		// Position of the Player relative to the upper left side of the screen
		public Vector2 Position;

		// State of the player
		private bool active;
		public bool Active
		{
			get { return active;}
			set { active = value;}
		}

		// Amount of hit points that player has
		private int health;
		public int Health
		{
			get { return health;}
			set { health = value;}
		}

		// Get the width of the player ship
		public int Width
		{
		get { return PlayerAnimation.FrameWidth; }
		}

		// Get the height of the player ship
		public int Height
		{
			get { return PlayerAnimation.FrameHeight; }
		}

			public Player()
			{
					
			}
			public void Initialize(Animation animation, Vector2 position)
			{
			PlayerAnimation = animation;

			// Set the starting position of the player around the middle of the screen and to the back
			Position = position;

			// Set the player to be active
			Active = true;

			// Set the player health
			Health = 100;
			}

			// Update the player animation
			public void Update(GameTime gameTime)
			{
				PlayerAnimation.Position = Position;
				PlayerAnimation.Update(gameTime);
			}

			// Draw the player
			public void Draw(SpriteBatch spriteBatch)
			{
				PlayerAnimation.Draw(spriteBatch);
			}
		}
}

		

