using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace UnityDungeon
{
    public class DungeonLayout : MonoBehaviour
    {
        public enum RoomContent{
            MONSTER,
            CHEST,
            BOSS,
        }
        private RoomContent[] rooms;
        public int currentRoomIndex;

        // Start is called before the first frame update
        void Start()
        {
            createDungeon(5);
        }

        public void createDungeon(int nbRooms)
        {
            currentRoomIndex = 1;
            rooms = new RoomContent[(int)Mathf.Pow(2f, (float)nbRooms) - 1];
            for (int i = 0 ; i < (int)Mathf.Pow(2f, nbRooms) - 1 ; ++i)
            {
                if(i > (int)(Mathf.Pow(2f, nbRooms - 1) - 1))
                {
                    rooms.SetValue(RoomContent.BOSS, i);
                }
                else 
                {
                    if(Random.Range(0.0f, 1.0f) > 0.5f)
                    {
                        rooms.SetValue(RoomContent.MONSTER, i);
                    }
                    else
                    {
                        rooms.SetValue(RoomContent.CHEST, i);
                    } 
                }
                Debug.Log(rooms[i]);
            }
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void onLeftDoorButtonClicked()
        {
            currentRoomIndex = currentRoomIndex * 2;
            enterRoom(currentRoomIndex);
        }

        public void onRightDoorButtonClicked()
        {
            currentRoomIndex = currentRoomIndex * 2 + 1;
            enterRoom(currentRoomIndex);
        }

        public void enterRoom(int index)
        {
            if(rooms[index-1] == RoomContent.MONSTER)
            {
                /*CharacterData en = new CharacterData();
                CharacterData pl = new CharacterData();
                FightScript fight = new FightScript(en, pl);*/
            }
        }   
    }
}

