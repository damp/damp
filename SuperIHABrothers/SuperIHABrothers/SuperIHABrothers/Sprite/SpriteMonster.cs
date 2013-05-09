///////////////////////////////////////////////////////////
//  SpriteMonster.cs
//  Implementation of the Class SpriteMonster
//  Generated by Enterprise Architect
//  Created on:      16-apr-2013 11:48:22
//  Original author: Space-Punk
///////////////////////////////////////////////////////////


using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace Sprites {
	public class SpriteMonster : ISprite {

        //Generel Atributes
        public Vector2 Position { get; set; }
	    private Vector2 _AnchorOffset;
        public Rectangle MyRectangle { get; set; }
	    public Vector2 Velocity { get; set; }
	    public bool _isInAir { get; set; }
	    private IAnchor _Anchor;
        private int _FrameHeight;
        private int _FrameWidth;
	    private Texture2D _texture2D;

        //Animation Atributes
	    private int _interval = 75; 
        private int _currentFrame;
        private float _timer = 0;
        
        //Moving Atributes
        public Vector2 Velocety { get { return _velocety; } set { _velocety = value; } }
        private Vector2 _velocety;
        
        

        public SpriteMonster(Texture2D mTexture2D, Vector2 mAnchorOffset, int mFrameHeight, int mFrameWidth, IAnchor mAnchor, Vector2 mVelocety)
        {
            throw new NotImplementedException();
        }

	    public void Draw(SpriteBatch spriteBatch)
	    {
	        throw new NotImplementedException();
	    }

	    
	    public void Update(GameTime time)
	    {
	        throw new NotImplementedException();
	    }

	    public void UpdatePosition()
	    {
	        throw new NotImplementedException();
	    }

	    private void AnimateLeft(GameTime gameTime)
        {
            _timer += (float)gameTime.ElapsedGameTime.TotalMilliseconds / 2;
            if (_timer > _interval)
            {
                _currentFrame++;
                _timer = 0;
                if (_currentFrame > 7 || _currentFrame < 4 || _isInAir)
                {
                    _currentFrame = 4;
                }
            }
        }

        private void AnimateRight(GameTime gameTime)
        {
            _timer += (float)gameTime.ElapsedGameTime.TotalMilliseconds / 2;
            if (_timer > _interval)
            {
                _currentFrame++;
                _timer = 0;
                if (_currentFrame > 3 || _isInAir)
                {
                    _currentFrame = 0;
                }
            }
        }
	}//end SpriteMonster

}//end namespace Sprites