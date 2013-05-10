﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprites;

namespace Sprite
{
    class SpriteFinishLine : ISprite
    {
        //General Attributes
        public Vector2 Position { get { return _position; } set { _position = value; } }
	    private Vector2 _position; 
        public Rectangle MyRectangle { get { return _rectangle; } set { _rectangle = value; } }
	    public Vector2 Velocity { get; set; }
	    public bool _isInAir { get; set; }
	    public IAnchor _anchor;
        private Vector2 _AnchorOffset;
	    private Texture2D _texture2D;
	    private int _FrameHeight;
	    private int _FrameWidth;
	    private Rectangle _rectangle;

        public SpriteFinishLine(Texture2D mTexture2D, Vector2 mAnchorOffset, int mFrameHeight, int mFrameWidth, IAnchor mAnchor)
        {
            _FrameHeight = mFrameHeight;
            _FrameWidth = mFrameWidth;
            _texture2D = mTexture2D;
            _AnchorOffset = mAnchorOffset;
            _anchor = mAnchor;
        }

	    public void Draw(SpriteBatch spriteBatch)
	    {
	        spriteBatch.Draw(_texture2D, _rectangle, Color.White);
	    }

	    
	    public void Update(GameTime time)
	    {
	        _position.X = _anchor.Position.X + _AnchorOffset.X;
	        _position.Y = _anchor.Position.Y + _AnchorOffset.Y;
            MyRectangle = new Rectangle((int)Position.X, (int)Position.Y, _FrameWidth, _FrameHeight);
	    }

	    public void UpdatePosition()
	    {
            MyRectangle = new Rectangle((int)Position.X, (int)Position.Y, _FrameWidth, _FrameHeight);
	    }
    }
}
