using Raylib_cs;
using System.Numerics;

Raylib.InitWindow(800, 480, "Hello World");

Vector2 playerPosition = new Vector2(100, 200);

Rectangle sourceDown = new Rectangle(0, 0, 100, 150);

Rectangle sourceUp = new Rectangle(0, 150, 100, 150);

Rectangle sourceLeft = new Rectangle(0, 300, 100, 150);

Rectangle sourceRight = new Rectangle(0, 450, 100, 150);


Raylib.SetTargetFPS(60);

Texture2D personage = Raylib.LoadTexture("spritepersonage.png");

Rectangle oneDirection = sourceDown; //ignorar nome :p

while (!Raylib.WindowShouldClose())
{
    if (Raylib.IsKeyDown(KeyboardKey.Right))
    {
        playerPosition.X += 2.0f;
        oneDirection = sourceRight;

    }
    if (Raylib.IsKeyDown(KeyboardKey.Left))
    {
        playerPosition.X -= 2.0f;
        oneDirection = sourceLeft;

    }
    if (Raylib.IsKeyDown(KeyboardKey.Up))
    {
        playerPosition.Y -= 2.0f;
        oneDirection = sourceUp;
    }
    if (Raylib.IsKeyDown(KeyboardKey.Down))
    {
        playerPosition.Y += 2.0f;
        oneDirection = sourceDown;

    }

    Raylib.BeginDrawing();

    Raylib.DrawFPS(50, 60);

    Raylib.ClearBackground(Color.White);


    //Raylib.DrawCircleV(ballPosition, 50, Color.Red);
    //Raylib.DrawTextureV(personage, ballPosition, Color.White); // semprebranco de preferencia
    Rectangle dest = new Rectangle(playerPosition.X, playerPosition.Y, 100, 150);


    Raylib.DrawTexturePro(personage, oneDirection, dest, new(0,0), 0, Color.White);

    Raylib.EndDrawing();
}

Raylib.CloseWindow();
    
