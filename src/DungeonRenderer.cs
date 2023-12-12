using Dungeon_Crawl.src.Character;
using Dungeon_Crawl.src.Dungeon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dungeon_Crawl.src
{
    internal class DungeonRenderer
    {
        private Bitmap drawingBitmap;
        private Image wallTexture;
        private float fov = (float)Math.PI / 4.5f, depth = 16.0f;
        private MapData map; // Your map data
        private float playerX, playerY, playerAngle;

        private float offsetX = .5f;
        private float offsetY = .5f;
        private float rotationOffset = 0;
        private static DungeonRenderer instance;

        public static DungeonRenderer Instance { get => instance; private set => instance = value; }

        public DungeonRenderer(int width, int height, Image texture)
        {
            instance = this;
            this.drawingBitmap = new Bitmap(1920, 1080);
            this.wallTexture = texture;
        }

        public Bitmap RenderFrame()
        {
            DrawDungeon();
            return drawingBitmap;
        }

        // Paint event handler for PictureBox
        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(drawingBitmap, 0, 0);
            DrawDungeon();
        }

        private void DrawDungeon()
        {
            int screenWidth = drawingBitmap.Width;
            int screenHeight = drawingBitmap.Height;

            float wallX = 0; // Horizontal position on the wall for texture mapping
            map = MapData.Get;
            for (int x = 0; x < screenWidth; x++)
            {
                // Calculate ray angle
                float rayAngle = playerAngle - fov / 2 + (x / (float)screenWidth) * fov;

                // Initialize distance to wall
                float distanceToWall = 0;
                bool hitWall = false;

                float eyeX = (float)Math.Cos(rayAngle); // Unit vector for ray in player space
                float eyeY = (float)Math.Sin(rayAngle);

                // Incrementally step ray outwards from player position
                while (!hitWall && distanceToWall < depth)
                {
                    distanceToWall += 0.1f; // Step size

                    int testX = (int)(playerX + eyeX * distanceToWall);
                    int testY = (int)(playerY + eyeY * distanceToWall);

                    // Test if ray is out of bounds
                    if (testX < 0 || testX >= map.GetSizeX() || testY < 0 || testY >= map.GetSizeY())
                    {
                        hitWall = true; // Set distance to maximum depth
                        distanceToWall = depth;
                    }
                    else if (map.GetTile(testX, testY) == 1) // Ray is inbounds and hit wall
                    {
                        hitWall = true;

                        // Calculate exact position where ray hits the wall
                        float hitX = playerX + eyeX * distanceToWall;
                        float hitY = playerY + eyeY * distanceToWall;

                        // Determine which part of the wall texture to sample (wallX)
                        wallX = hitX % 1;
                        if (Math.Abs(eyeX) > Math.Abs(eyeY))
                        {
                            wallX = hitY % 1;
                        }
                        wallX = wallX - (int)wallX;

                        // Correct distance for fish-eye effect
                        float relativeAngle = rayAngle - playerAngle;
                        distanceToWall *= (float)Math.Cos(relativeAngle);
                    }
                }

                // Calculate the height of the wall slice
                int wallHeight = (int)(screenHeight / distanceToWall);

                // Calculate distance to ceiling and floor
                int ceiling = (screenHeight / 2) - (wallHeight / 2);
                int floor = ceiling + wallHeight;

                // Draw wall slice, floor, and ceiling
                for (int y = 0; y < screenHeight; y++)
                {
                    if (y <= ceiling)
                    {
                        drawingBitmap.SetPixel(x, y, Color.Black); // Ceiling color
                    }
                    else if (y > ceiling && y <= floor)
                    {
                        float sampleY = (y - ceiling) / (float)(wallHeight);
                        Color color = GetTextureColor(wallTexture, wallX, sampleY);
                        drawingBitmap.SetPixel(x, y, color); // Wall color
                    }
                    else
                    {
                        drawingBitmap.SetPixel(x, y, Color.Gray); // Floor color
                    }
                }
            }
        }

        private Color GetTextureColor(Image texture, float wallX, float sampleY)
        {
            try
            {
                Bitmap bmp = texture as Bitmap;
                int textureX = (int)(wallX * bmp.Width);
                int textureY = (int)(sampleY * bmp.Height);

                // Clamp textureX and textureY to the bitmap bounds
                textureX = Clamp(textureX, 0, bmp.Width - 1);
                textureY = Clamp(textureY, 0, bmp.Height - 1);

                return bmp.GetPixel(textureX, textureY);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                // Handle exception (e.g., log the error and return a default color)
                Console.WriteLine("GetPixel out of range: " + ex.Message);
                return Color.Magenta; // Using a standout color for debugging
            }
        }

        public void UpdatePlayerPosition(float x, float y)
        {
            playerX = x + offsetX;
            playerY = y + offsetY;
            DungeonForm form = Form.ActiveForm as DungeonForm;
            form.InvalidateDungeonBackground();
        }

        public void UpdatePlayerAngle(float angle)
        {
            playerAngle = angle + rotationOffset;
            DungeonForm form = Form.ActiveForm as DungeonForm;
            form.InvalidateDungeonBackground();
        }

        private int Clamp(int value, int min, int max)
        {
            if (value < min)
                return min;
            else if (value > max)
                value = max;

            return value;
        }
    }
}