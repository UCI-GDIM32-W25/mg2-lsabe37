[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/7qg5CCgx)
# HW2
## Devlog
I used the MG2 breakdown to help me set up the game objects of Minigame 2 and get an idea on how to create the player, coin, and coin spawner scripts. Like in the breakdown, I set up my player game object with a SpriteRenderer, CapsuleCollider2D, Rigidbody2D, and Player script. The Player script included logic that allowed the player game object to jump when the player presses the space bar. I set up the coin game object as a prefab that gets instantiated by the coin spawner game object. The coin game object was set up with a SpriteRenderer, CapsuelCollider2D set to IsTrigger, Rigidbody2D, and Coin script. The Coin script included logic that moved the coins to the left and destroyed the coin game object if it collided with the player or out-of-bounds collider. The coin spawner game object was set up with the Coin Spawner script. The Coin Spawner script includes logic that instantiates a coin prefab at the transform.position after a randomly generated delay. Finally, I set up the floor game object with a BoxCollider2D and SpriteRenderer. 


## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - rabbit and item sprites
- [Pixel Penguin 32x32 Asset pack](https://legends-games.itch.io/pixel-penguin-32x32-asset-pack) - penguin sprites
- [Coins 2D](https://artist2d3d.itch.io/2d) - coin sprites