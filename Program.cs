using Raylib_cs;
using System.Numerics;

Raylib.InitWindow(800, 480, "Hello World");

Vector2 ballPosition = new Vector2(100, 200);

Rectangle source = new Rectangle(0, 0, 100, 150);

Raylib.SetTargetFPS(60);

Texture2D personage = Raylib.LoadTexture("spritepersonage.png");

while (!Raylib.WindowShouldClose())
{
    if (Raylib.IsKeyDown(KeyboardKey.Right)) ballPosition.X += 2.0f;
    if (Raylib.IsKeyDown(KeyboardKey.Left)) ballPosition.X -= 2.0f;
    if (Raylib.IsKeyDown(KeyboardKey.Up)) ballPosition.Y -= 2.0f;
    if (Raylib.IsKeyDown(KeyboardKey.Down)) ballPosition.Y += 2.0f;


    Raylib.BeginDrawing();

    Raylib.DrawFPS(50, 60);

    Raylib.ClearBackground(Color.White);

    Raylib.DrawText("Hello, world!", 12, 12, 20, Color.Black);

    //Raylib.DrawCircleV(ballPosition, 50, Color.Red);
    //Raylib.DrawTextureV(personage, ballPosition, Color.White); // semprebranco de preferencia
    Rectangle dest = new Rectangle(ballPosition.X, ballPosition.Y, 100, 150);


    Raylib.DrawTexturePro(personage, source, dest, new(0,0), 0, Color.White);

    Raylib.EndDrawing();
}

Raylib.CloseWindow();
    
