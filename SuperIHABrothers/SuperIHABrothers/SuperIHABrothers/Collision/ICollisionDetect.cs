///////////////////////////////////////////////////////////
//  ICollisionDetect.cs
//  Implementation of the Interface ICollisionDetect
//  Generated by Enterprise Architect
//  Created on:      16-apr-2013 11:50:49
//  Original author: Space-Punk
///////////////////////////////////////////////////////////



using Sprites;
using System.Collections.Generic;
namespace Collision {
	public interface ICollisionDetect  {

		/// 
		/// <param name="mSpriteCollection"></param>
		/// <param name="mSprite2"></param>
		/// <param name="mSprite1"></param>
		void Detect(ISpriteContainerCollision mSpriteCollection, ISprite mSprite2, ISprite mSprite1);
	}//end ICollisionDetect

}//end namespace CollitionControle