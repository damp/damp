///////////////////////////////////////////////////////////
//  ISprite.cs
//  Implementation of the Interface ISprite
//  Generated by Enterprise Architect
//  Created on:      16-apr-2013 11:48:21
//  Original author: Space-Punk
///////////////////////////////////////////////////////////



using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprites {
	public interface ISprite  {

        void Draw(SpriteBatch spriteBatch);

		Vector2 Position{
			get;
			set;
		}

        Rectangle MyRectangle
        {
            get; set; }

        Vector2 Velocity { get; set; }
        bool _isInAir { get; set; }
        void Update(GameTime time);
	    void UpdatePosition();
	}//end ISprite

}//end namespace Sprites