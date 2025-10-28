# Turkey Hunt

Duck Hunt, but turkeys

## Playing the Game
In this game, you play as a hunter trying to shoot the turkeys to gain points. Every 10 turkeys, the difficulty increases. Your goal is to get a perfect score of 50 points.

## How I Made this Game

I created this game in Unity, and created the art by hand in Aseprite. The order of operations is as follows:

1. Used simple shapes to block out the simple mechanics/actions
     - Spawning enemies
     - Having enemies move towards a random direction
     - Shooting enemies
2. Creating all of the art for the game
     - The background (2 hrs)
     - The Turkey sprite (30 min)
     - They Score stuff (15 min)
     - The Bullets  (10 min)
     - The crosshair (5 min)
3. Implementing scoring (semi-state machine)
     - Tracking if you hit a turkey
     - Setting a score dashboard at the bottom to reflect which turkeys were shot out of 10 each round
     - Resting this dashboard at a new round
4. Implementing new rounds
     - When all 10 turkeys come out, the new round starts
     - When a new round starts, the turkeys fly faster
     - When the 5th round ends, the end scene shows
5. Add an end scene
     -  Add text to show how many turkeys the player got
     -  Add a button to replay the game.

## What I wish I could have done
- Adding a home/start screen
- Adding music/sound effects
- Caping shots to 3 per turkey
    - I made the art for it, and it's even still in the final post, but it sadly does not work
    - I added functionality earlier in development, but something I added must have broken it
    - I sadly didn't have time to fix it

## Gameplay Video
https://github.com/user-attachments/assets/ce15551d-835f-48dc-a0ff-5d10137b9ba5


