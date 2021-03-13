const http = require('http');
const url = require('url');
const port = 3000;

const requestHandler = (request, response) => {

    const query = url.parse(request.url, true).query;
	
    let apiObjects = [
            {itemImg: "Assets/Items/Butter.png", itemName: "Butter", itemCount: 1, itemPrice: 100, playerName: "Player 1", playerImg: "Assets/Players/PlayerAvatar1.jpg"},
			{itemImg: "Assets/Items/Corn.png", itemName: "Corn", itemCount: 2, itemPrice: 200, playerName: "Player 2", playerImg: "Assets/Players/PlayerAvatar3.jpg"},
			{itemImg: "Assets/Items/Mushrooms.png", itemName: "Mushrooms", itemCount: 3, itemPrice: 300, playerName: "Player 3", playerImg: "Assets/Players/PlayerAvatar3.jpg"},
			{itemImg: "Assets/Items/Wheat.png", itemName: "Wheat", itemCount: 4, itemPrice: 400, playerName: "Player 4", playerImg: "Assets/Players/PlayerAvatar1.jpg"},
			{itemImg: "Assets/Items/Butter.png", itemName: "Butter", itemCount: 5, itemPrice: 120, playerName: "Player 5", playerImg: "Assets/Players/PlayerAvatar2.jpg"},
			{itemImg: "Assets/Items/Corn.png", itemName: "Corn", itemCount: 6, itemPrice: 230, playerName: "Player 6", playerImg: "Assets/Players/PlayerAvatar6.jpg"},
			{itemImg: "Assets/Items/Mushrooms.png", itemName: "Mushrooms", itemCount: 7, itemPrice: 340, playerName: "Player 7", playerImg: "Assets/Players/PlayerAvatar1.jpg"},
			{itemImg: "Assets/Items/Wheat.png", itemName: "Wheat", itemCount: 8, itemPrice: 450, playerName: "Player 8", playerImg: "Assets/Players/PlayerAvatar3.jpg"},
			{itemImg: "Assets/Items/Butter.png", itemName: "Butter", itemCount: 9, itemPrice: 563, playerName: "Player 9", playerImg: "Assets/Players/PlayerAvatar5.jpg"},
			{itemImg: "Assets/Items/Corn.png", itemName: "Corn", itemCount: 10, itemPrice: 123, playerName: "Player 10", playerImg: "Assets/Players/PlayerAvatar1.jpg"},
			{itemImg: "Assets/Items/Mushrooms.png", itemName: "Mushrooms", itemCount: 11, itemPrice: 67, playerName: "Player 11", playerImg: "Assets/Players/PlayerAvatar2.jpg"},
			{itemImg: "Assets/Items/Wheat.png", itemName: "Wheat", itemCount: 12, itemPrice: 809, playerName: "Player 12", playerImg: "Assets/Players/PlayerAvatar6.jpg"},
			{itemImg: "Assets/Items/Butter.png", itemName: "Butter", itemCount: 1, itemPrice: 100, playerName: "Player 1", playerImg: "Assets/Players/PlayerAvatar1.jpg"},
			{itemImg: "Assets/Items/Corn.png", itemName: "Corn", itemCount: 2, itemPrice: 200, playerName: "Player 2", playerImg: "Assets/Players/PlayerAvatar4.jpg"},
			{itemImg: "Assets/Items/Mushrooms.png", itemName: "Mushrooms", itemCount: 3, itemPrice: 300, playerName: "Player 3", playerImg: "Assets/Players/PlayerAvatar3.jpg"},
			{itemImg: "Assets/Items/Wheat.png", itemName: "Wheat", itemCount: 4, itemPrice: 400, playerName: "Player 4", playerImg: "Assets/Players/PlayerAvatar4.jpg"},
			{itemImg: "Assets/Items/Butter.png", itemName: "Butter", itemCount: 5, itemPrice: 120, playerName: "Player 5", playerImg: "Assets/Players/PlayerAvatar5.jpg"},
			{itemImg: "Assets/Items/Corn.png", itemName: "Corn", itemCount: 6, itemPrice: 230, playerName: "Player 6", playerImg: "Assets/Players/PlayerAvatar3.jpg"},
			{itemImg: "Assets/Items/Mushrooms.png", itemName: "Mushrooms", itemCount: 7, itemPrice: 340, playerName: "Player 7", playerImg: "Assets/Players/PlayerAvatar5.jpg"},
			{itemImg: "Assets/Items/Wheat.png", itemName: "Wheat", itemCount: 8, itemPrice: 450, playerName: "Player 8", playerImg: "Assets/Players/PlayerAvatar1.jpg"},
			{itemImg: "Assets/Items/Butter.png", itemName: "Butter", itemCount: 9, itemPrice: 563, playerName: "Player 9", playerImg: "Assets/Players/PlayerAvatar3.jpg"},
			{itemImg: "Assets/Items/Corn.png", itemName: "Corn", itemCount: 10, itemPrice: 123, playerName: "Player 10", playerImg: "Assets/Players/PlayerAvatar4.jpg"},
			{itemImg: "Assets/Items/Mushrooms.png", itemName: "Mushrooms", itemCount: 11, itemPrice: 67, playerName: "Player 11", playerImg: "Assets/Players/PlayerAvatar5.jpg"},
			{itemImg: "Assets/Items/Wheat.png", itemName: "Wheat", itemCount: 12, itemPrice: 809, playerName: "Player 12", playerImg: "Assets/Players/PlayerAvatar2.jpg"}
        ];

    response.end(JSON.stringify(apiObjects));    
};

const server = http.createServer(requestHandler);

server.listen(port, (err) => {

    if (err) {
        return console.log(`Internal Server Error: ${err}`);
    }

    console.log(`Listening on port: ${port}`);
});