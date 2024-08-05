using Raylib_cs;
using System.Numerics;

//configurar segunda parte das animacoes
Raylib.InitWindow(800, 480, "Hello World");

Vector2 playerPosition = new Vector2(100, 200);


//coordenadas do sprite
Rectangle sourceDown = new Rectangle(0, 0, 100, 150);

Rectangle sourceDown2 = new Rectangle(100, 0, 100, 150);

Rectangle sourceUp = new Rectangle(0, 150, 100, 150);

Rectangle sourceUp2 = new Rectangle(100, 150, 100, 150);

Rectangle sourceLeft = new Rectangle(0, 300, 100, 150);

Rectangle sourceLeft2 = new Rectangle(100, 300, 100, 150);

Rectangle sourceRight = new Rectangle(0, 450, 100, 150);

Rectangle sourceRight2 = new Rectangle(100, 450, 100, 150);

Raylib.SetTargetFPS(60);

Texture2D personage = Raylib.LoadTexture("spritepersonage.png"); // jogar a imagem no: C:\Users\teu user\source\repos\GestaoAcao\GestaoAcao\bin\Debug\net8.0

Rectangle oneDirection = sourceDown; //ignorar nome :p

while (!Raylib.WindowShouldClose())
{
    bool isMoving = false;

    // parte q reconhece as entradas do teclado para mover o personagem
    if (Raylib.IsKeyDown(KeyboardKey.Right))
    {
        playerPosition.X += 2.0f;
        oneDirection = sourceRight2;
        isMoving = true;
    }

    if (Raylib.IsKeyDown(KeyboardKey.Left))
    {
        playerPosition.X -= 2.0f;
        oneDirection = sourceLeft2;
        isMoving = true;

    }
    if (Raylib.IsKeyDown(KeyboardKey.Up))
    {
        playerPosition.Y -= 2.0f;
        oneDirection = sourceUp2;
        isMoving = true;
    }
    if (Raylib.IsKeyDown(KeyboardKey.Down))
    {
        playerPosition.Y += 2.0f;
        oneDirection = sourceDown2;
        isMoving = true;
    }

    //verifica se o personagem esta em movimento para fazer a animacao andando
    if (!isMoving && oneDirection.Equals(sourceDown2))
    {
        oneDirection = sourceDown;
    }

    if (!isMoving && oneDirection.Equals(sourceUp2))
    {
        oneDirection = sourceUp;
    }

    if (!isMoving && oneDirection.Equals(sourceLeft2))
    {
        oneDirection = sourceLeft;
    }

    if (!isMoving && oneDirection.Equals(sourceRight2))
    {
        oneDirection = sourceRight;
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
    
