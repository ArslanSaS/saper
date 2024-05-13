using System;
using System.Drawing;
using System.Windows.Forms;

namespace saper
{
    public partial class Form1 : Form
    {
        public const int mapSize = 8;
        public const int cellSize = 50;

        public int[,] map = new int[mapSize, mapSize];
        public Button[,] buttons = new Button[mapSize, mapSize];

        public Form1()
        {
            InitializeComponent();

            Init();
        }
        private void Init()
        {
            ConfigureMapSize();
            InitMap();
            InitButton();
        }

        private void ConfigureMapSize()
        {
            this.Width = mapSize * cellSize + 20;
            this.Height = (mapSize + 1) * cellSize;
        }

        private void InitMap()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    map[i, j] = 0;
                }
            }

        }
        private void InitButton()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    Button button = new Button();
                    button.Location = new Point(j * cellSize, i * cellSize);
                    button.Size = new Size(cellSize, cellSize);
                    this.Controls.Add(button);
                    buttons[i, j] = button;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
