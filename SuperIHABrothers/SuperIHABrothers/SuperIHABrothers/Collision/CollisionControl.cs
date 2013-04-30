///////////////////////////////////////////////////////////
//  CollisionControl.cs
//  Implementation of the Class CollisionControl
//  Generated by Enterprise Architect
//  Created on:      16-apr-2013 11:50:49
//  Original author: Filip V
///////////////////////////////////////////////////////////


using System.Collections.Generic;
using Sprites;

namespace Collision
{
    public class CollisionControl : ICollisionControl
    {
        private ISpriteContainerCollision _spriteContainerCollision;
        private ICollisionDetect _playerEnviromentDetect;
        private ICollisionDetect _playerMonsterDetect;
        private ICollisionDetect _monsterEnviromentDetect;

        public CollisionControl(ISpriteContainerCollision mSpriteContainerCollision, ICollisionDetect mPlayerEnviromentDetect)
        {
            _spriteContainerCollision = mSpriteContainerCollision;
            _playerEnviromentDetect = mPlayerEnviromentDetect;
        }


        /// 
        /// <param name="mSprites"></param>
        public List<IEvent> Update()
        {
            List<IEvent> eventList = new List<IEvent>();

            for (int i = 0; i < _spriteContainerCollision.SpriteList.Count; i++)
            {
                for (int j = i + 1; j < _spriteContainerCollision.SpriteList.Count; j++)
                {
                    if (_spriteContainerCollision.SpriteList[i].MyRectangle.Intersects(
                        _spriteContainerCollision.SpriteList[j].MyRectangle))
                    {
                        CallRightDetector(_spriteContainerCollision.SpriteList[i],
                                          _spriteContainerCollision.SpriteList[j], eventList);
                    }
                }
            }
            return eventList;
        }

        private void CallRightDetector(ISprite spriteOne, ISprite spriteTwo, List<IEvent> eventList)
        {
            // Player - Environment
            if (((spriteOne.GetType() == typeof (SpritePlayer)) && (spriteTwo.GetType() == typeof (SpriteEnvironment))) ||
                ((spriteOne.GetType() == typeof (SpriteEnvironment)) && (spriteTwo.GetType() == typeof (SpritePlayer))))
            {
                _playerEnviromentDetect = new PlayerEnviromentDetect();
                eventList.Add(_playerEnviromentDetect.Detect(_spriteContainerCollision, spriteOne, spriteTwo));
            }
                // Player - Monster
            else if (((spriteOne.GetType() == typeof (SpritePlayer)) && (spriteTwo.GetType() == typeof (SpriteMonster))) ||
                     ((spriteOne.GetType() == typeof (SpriteMonster)) && (spriteTwo.GetType() == typeof (SpritePlayer))))
            {
                PlayerMonsterDetect pmDetect = new PlayerMonsterDetect();
                eventList.Add(pmDetect.Detect(_spriteContainerCollision, spriteOne, spriteTwo));
            }
                // Monster - Environment
            else if (((spriteOne.GetType() == typeof (SpriteEnvironment)) && (spriteTwo.GetType() == typeof (SpriteMonster))) ||
                     ((spriteOne.GetType() == typeof (SpriteMonster)) && (spriteTwo.GetType() == typeof (SpriteEnvironment))))
            {
                MonsterEnviromentDetect meDetect = new MonsterEnviromentDetect();
                eventList.Add(meDetect.Detect(_spriteContainerCollision, spriteOne, spriteTwo));
            }
        }
    }

//end CollisionControl
}

//end namespace CollitionControl