///////////////////////////////////////////////////////////
//  Level1.cs
//  Implementation of the Class Level1
//  Generated by Enterprise Architect
//  Created on:      16-apr-2013 11:49:45
//  Original author: Space-Punk
///////////////////////////////////////////////////////////




using Collision;
using GameControle;
using Microsoft.Xna.Framework.Graphics;
using Sprites;
using EventHandling;
using GameState;
using Microsoft.Xna.Framework;
namespace GameControle {
	public class Level1 : ILevel {

		private Collision.ICollisionControl MiCollisionControl;
		private Sprites.ISpriteContainer m_ISpriteContainer;
	    private ISpriteContainerCollision _spriteContainerCollision;

		public Level1(ISpriteContainer mSpriteContainer, ISpriteContainerCollision mSpriteContainerCollision, ICollisionControl collisionControl)
		{
		    m_ISpriteContainer = mSpriteContainer;
		    _spriteContainerCollision = mSpriteContainerCollision;
		    MiCollisionControl = collisionControl;
		}


		public void Draw(SpriteBatch spriteBatch){
            m_ISpriteContainer.Draw(spriteBatch);
		}

		public void NewLevel()
        {

		}

		public void Update(GameTime time)
        {
            m_ISpriteContainer.Update(time);
            MiCollisionControl.Update(_spriteContainerCollision);
		}

	}//end Level1

}//end namespace GameControle