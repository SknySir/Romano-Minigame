# Romano-Minigame
 Minigame assignment
Name of Game : Boundless

Discription : This game is a simple move and shoot game where enemies spawn for 90 seconds and you must destroy as many as posible.. Enemies will be moving leftward and will exit and reapear on the right side of level. Your job is to destroy them with your projectile.

How To Play : Move with "A" and "D", Shoot with "Space"

Dev Log : I used basic movement features like adding a player controller to the users player allowing them to move left and right. 
The player is locked between a -xRange and Xrange. enemies have a vector3.right continuously moving them with also a coninuous loop when interacting with the same -xRange and XRange. 
The players projectile have a move forward script and can collide with the enemies, destroying them. There is a score feature that increases an int everytime you destroy an enemy with your projectile.
There is a 90 second Timer that will take you to a game over scene with a button allowing you to start over.