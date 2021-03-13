using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Database
{
    public ItemModel[] items;

    public Database()
    {
        items = new ItemModel[24];

		for(int i = 0; i < items.Length; i++)
        {
			items[i] = new ItemModel();
        }

		items[0].itemImg = "Assets/Items/Butter.png"; items[0].itemName = "Butter"; items[0].itemCount = 1; items[0].itemPrice = 100; items[0].playerName = "Player 1"; items[0].playerImg = "Assets/Players/PlayerAvatar1.jpg";
		items[1].itemImg = "Assets/Items/Corn.png"; items[1].itemName = "Corn"; items[1].itemCount = 2; items[1].itemPrice = 200; items[1].playerName = "Player 2"; items[1].playerImg = "Assets/Players/PlayerAvatar3.jpg";
		items[2].itemImg = "Assets/Items/Mushrooms.png"; items[2].itemName = "Mushrooms"; items[2].itemCount = 3; items[2].itemPrice = 300; items[2].playerName = "Player 3"; items[2].playerImg = "Assets/Players/PlayerAvatar3.jpg";
		items[3].itemImg = "Assets/Items/Wheat.png"; items[3].itemName = "Wheat"; items[3].itemCount = 4; items[3].itemPrice = 400; items[3].playerName = "Player 4"; items[3].playerImg = "Assets/Players/PlayerAvatar1.jpg";
		items[4].itemImg = "Assets/Items/Butter.png"; items[4].itemName = "Butter"; items[4].itemCount = 5; items[4].itemPrice = 120; items[4].playerName = "Player 5"; items[4].playerImg = "Assets/Players/PlayerAvatar2.jpg";		
		items[5].itemImg = "Assets/Items/Butter.png"; items[5].itemName = "Butter"; items[5].itemCount = 8; items[5].itemPrice = 23; items[5].playerName = "Player 3"; items[5].playerImg = "Assets/Players/PlayerAvatar1.jpg";
		items[6].itemImg = "Assets/Items/Corn.png"; items[6].itemName = "Corn"; items[6].itemCount = 1; items[6].itemPrice = 100; items[6].playerName = "Player 1"; items[6].playerImg = "Assets/Players/PlayerAvatar4.jpg";
		items[7].itemImg = "Assets/Items/Butter.png"; items[7].itemName = "Butter"; items[7].itemCount = 6; items[7].itemPrice = 797; items[7].playerName = "Player 4"; items[7].playerImg = "Assets/Players/PlayerAvatar2.jpg";
		items[8].itemImg = "Assets/Items/Wheat.png"; items[8].itemName = "Wheat"; items[8].itemCount = 2; items[8].itemPrice = 100; items[8].playerName = "Player 1"; items[8].playerImg = "Assets/Players/PlayerAvatar1.jpg";
		items[9].itemImg = "Assets/Items/Butter.png"; items[9].itemName = "Butter"; items[9].itemCount = 34; items[9].itemPrice = 190; items[9].playerName = "Player 1"; items[9].playerImg = "Assets/Players/PlayerAvatar1.jpg";
		items[10].itemImg = "Assets/Items/Butter.png"; items[10].itemName = "Butter"; items[10].itemCount = 1; items[10].itemPrice = 100; items[10].playerName = "Player 5"; items[10].playerImg = "Assets/Players/PlayerAvatar2.jpg";
		items[11].itemImg = "Assets/Items/Mushrooms.png"; items[11].itemName = "Mushrooms"; items[11].itemCount = 22; items[11].itemPrice = 100; items[11].playerName = "Player 6"; items[11].playerImg = "Assets/Players/PlayerAvatar2.jpg";
		items[12].itemImg = "Assets/Items/Butter.png"; items[12].itemName = "Butter"; items[12].itemCount = 3; items[12].itemPrice = 100; items[12].playerName = "Player 1"; items[12].playerImg = "Assets/Players/PlayerAvatar1.jpg";
		items[13].itemImg = "Assets/Items/Corn.png"; items[13].itemName = "Corn"; items[13].itemCount = 17; items[13].itemPrice = 546; items[13].playerName = "Player 1"; items[13].playerImg = "Assets/Players/PlayerAvatar3.jpg";
		items[14].itemImg = "Assets/Items/Wheat.png"; items[14].itemName = "Wheat"; items[14].itemCount = 1; items[14].itemPrice = 54; items[14].playerName = "Player 1"; items[14].playerImg = "Assets/Players/PlayerAvatar1.jpg";
		items[15].itemImg = "Assets/Items/Butter.png"; items[15].itemName = "Butter"; items[15].itemCount = 41; items[15].itemPrice = 67; items[15].playerName = "Player 4"; items[15].playerImg = "Assets/Players/PlayerAvatar4.jpg";
		items[16].itemImg = "Assets/Items/Mushrooms.png"; items[16].itemName = "Mushrooms"; items[16].itemCount = 51; items[16].itemPrice = 100; items[16].playerName = "Player 1"; items[16].playerImg = "Assets/Players/PlayerAvatar1.jpg";
		items[17].itemImg = "Assets/Items/Butter.png"; items[17].itemName = "Butter"; items[17].itemCount = 1; items[17].itemPrice = 23; items[17].playerName = "Player 2"; items[17].playerImg = "Assets/Players/PlayerAvatar1.jpg";
		items[18].itemImg = "Assets/Items/Corn.png"; items[18].itemName = "Corn"; items[18].itemCount = 3; items[18].itemPrice = 100; items[18].playerName = "Player 1"; items[18].playerImg = "Assets/Players/PlayerAvatar3.jpg";
		items[19].itemImg = "Assets/Items/Wheat.png"; items[19].itemName = "Wheat"; items[19].itemCount = 1; items[19].itemPrice = 100; items[19].playerName = "Player 5"; items[19].playerImg = "Assets/Players/PlayerAvatar1.jpg";
		items[20].itemImg = "Assets/Items/Butter.png"; items[20].itemName = "Butter"; items[20].itemCount = 1; items[20].itemPrice = 300; items[20].playerName = "Player 7"; items[20].playerImg = "Assets/Players/PlayerAvatar1.jpg";
		items[21].itemImg = "Assets/Items/Corn.png"; items[21].itemName = "Corn"; items[21].itemCount = 9; items[21].itemPrice = 100; items[21].playerName = "Player 1"; items[21].playerImg = "Assets/Players/PlayerAvatar3.jpg";
		items[22].itemImg = "Assets/Items/Mushrooms.png"; items[22].itemName = "Mushrooms"; items[22].itemCount = 1; items[22].itemPrice = 100; items[22].playerName = "Player 2"; items[22].playerImg = "Assets/Players/PlayerAvatar1.jpg";
		items[23].itemImg = "Assets/Items/Butter.png"; items[23].itemName = "Butter"; items[23].itemCount = 67; items[23].itemPrice = 210; items[23].playerName = "Player 3"; items[23].playerImg = "Assets/Players/PlayerAvatar4.jpg";
	}
}
