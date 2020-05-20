using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true; //to prefent flickering
        }

        /*This here overrides an drawing parameter so the form and children don't flicker when getting updated*/
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        } 

        //defining static variables
        static int[,] map;
        static int[,] newMap;

        static int offset = 0;
        static int tileSize =5;
        static int mapSize = 800 / (offset + tileSize);

        static Random r = new Random();

        static int[] neighbours = new int[8];
        static int[] da = new int[2];   //dead-alive

        static int counter = 0;
       
        static int generation = 0;
        static bool gameStarted;

        static int[] mousePos = new int[2];

        static bool generateCave;

        //get called everytime after the method .Invalidate of the panel1 object is called(resets panel)
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
             for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (map[i, j] == 1)  // 1 = alive / 0 = dead
                    {
                        e.Graphics.FillRectangle(Brushes.Black, new Rectangle(i * (tileSize + offset), j * (tileSize + offset), tileSize, tileSize));
                       
                    }
                    else if (map[i, j] == 0)
                    {
                        e.Graphics.FillRectangle(Brushes.White, new Rectangle(i * (tileSize + offset), j * (tileSize + offset), tileSize, tileSize));
                    }
                }
            }
       
        }

        //The 'Main'-game loop
        private void timer1_Tick(object sender, EventArgs e)
        {            
            panel1.Invalidate();    //resets the panel         
            UpdateMap();           
            generation++;   //increases generation on every tick
            label4.Text = generation.ToString();    //prints out generation to the label
            swapMap();
       
            if (RandomMapcheckBox.Checked&&counter==1)  //checks if the checkbox for the randommap is checked
            {
                RandomMap();
                counter++;
            }
            
        }

        //function which turns the checkboxes on/off , when game is playing/paused
        void checkBoxes(bool state){
            if (state)
            {   
                //checkboxes
                GridFlag.Enabled = true;
                RandomMapcheckBox.Enabled = true;
                DrawcheckBox.Enabled = true;
                ErasecheckBox.Enabled = true;
                CavecheckBox.Enabled = true;

                MapSizetrackBar.Enabled = true;
                PatternComboBox.Enabled = true;
            }
            else {
                //checkboxes
                GridFlag.Enabled = false;
                RandomMapcheckBox.Enabled = false;
                DrawcheckBox.Enabled = false;
                ErasecheckBox.Enabled = false;
                CavecheckBox.Enabled = false;

                MapSizetrackBar.Enabled = false;
                PatternComboBox.Enabled = false;
            }

        }

        //function used for filling the map with random values
        void RandomMap() {
            for (int i = 1; i < mapSize-1; i++)
            {
                for (int j = 1; j < mapSize-1; j++)
                {   
                    int rate = r.Next(0,2);
                    if (rate != 0)
                    {
                        map[i, j] = 0;
                    }
                    else {
                        map[i, j] = 1;
                    }
                }
            }
            
        }

        //used for swaping old generation with the new
        void swapMap() {           
            for (int i = 1; i < mapSize - 1; i++)
            {
                for (int j = 1; j < mapSize - 1; j++)
                {
                    map[i, j] = newMap[i, j];
                    newMap[i,j]=0;                  
                }
            }  
        }

        void UpdateMap() {
            for (int i = 1; i < mapSize - 1; i++)
            {
                for (int j = 1; j < mapSize - 1; j++)
                {   
                    //Getting the neighbours of the cell
                    neighbours[0] = map[i + 1, j];
                    neighbours[1] = map[i + -1, j];

                    neighbours[2] = map[i + 1,j+1];
                    neighbours[3] = map[i ,j+1];
                    neighbours[4] = map[i - 1, j+1];

                    neighbours[5] = map[i + 1, j - 1];
                    neighbours[6] = map[i , j - 1];
                    neighbours[7] = map[i-1, j-1 ];

                    //counting how many of the neighbours are alive/dead
                    for (int k = 0; k < neighbours.Length; k++) {
                        if (neighbours[k] == 0)
                        {
                            da[0] += 1;
                        }
                        else {
                            da[1] += 1;
                        }
                    }                  
                    /*Game of life Conditions                    
                     1.Any live cell with fewer than two live neighbours dies, as if caused by under-population.
                     2.Any live cell with two or three live neighbours lives on to the next generation.
                     3.Any live cell with more than three live neighbours dies, as if by over-population.
                     4.Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.
                     */
                    
                    //Game of Life Rules  
                    if (!generateCave)
                    {
                        if (map[i, j] == 1)
                        {
                            //1.Condition 
                            if (da[1] < 2)
                            {
                                newMap[i, j] = 0;
                            }
                            //2.Condition
                            if (da[1] == 2 || da[1] == 3)
                            {
                                newMap[i, j] = 1;
                            }
                            //3.Condition
                            if (da[1] > 3)
                            {
                                newMap[i, j] = 0;
                            }
                        }

                        if (map[i, j] == 0)
                        {
                            //4.Condition
                            if (da[1] == 3)
                            {
                                newMap[i, j] = 1;
                            }
                        }
                    }

                    if (generateCave)
                    {

                        //4-5 Rules - for cave generation
                        //combinations 2-7 , 2-6 , 3-5 , 4-5(8 generations max)
                        if (map[i, j] == 1)
                        {
                            if (da[1] > 3)
                            {
                                newMap[i, j] = 1;
                            }
                            else
                            {
                                newMap[i, j] = 0;
                            }
                        }

                        if (map[i, j] == 0)
                        {
                            if (da[1] >= 5)
                            {
                                newMap[i, j] = 1;
                            }
                        }
                    }

                    //reseting the counter for dead/alive neighbours
                    da[0] = 0;
                    da[1] = 0;                                       
                }
            }
        }

        //function get's called when the Form is loaded
        private void Form1_Load(object sender, EventArgs e)
        {   
            map=new int[mapSize,mapSize];
            newMap = new int[mapSize, mapSize];                       
            timer1.Enabled = false;

            label6.Text = mapSize + "X" + mapSize;
            label1.Text = MapSizetrackBar.Value.ToString();

            GridFlag.Checked = true;
            updateMapValues();
        }
        
        //function which get's called when the play button is pressed
        private void PlayButton_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            counter++;
            gameStarted = true;
           
            checkBoxes(false);
        }

        //function which get's called when the pause button is pressed
        private void PauseButton_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            gameStarted = false;           
            checkBoxes(true);
        }

        public void ResetMap() {
            for (int i = 1; i < mapSize - 1; i++)
            {
                for (int j = 1; j < mapSize - 1; j++)
                {
                    map[i, j] = 0;
                    newMap[i, j] = 0;
                }
            }
            counter = 0;
        }
        //function which get's called when the reset button is pressed
        private void ResetButton_Click(object sender, EventArgs e)
        {            
            ResetMap();
            timer1.Enabled = false;
            generation = 0;
            label4.Text = generation.ToString();
            counter = 0;

            checkBoxes(true);
            panel1.Invalidate();           
        }

        //function for getting the position of the mouse click and drawing then on the map
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            mousePos[0] = e.Location.X / (tileSize + offset);   //getting the x position of the mouse and calculating the offset of the tiles
            mousePos[1] = e.Location.Y / (tileSize + offset);
            
            //Drawing Cells
            if (DrawcheckBox.Checked&&!gameStarted) {   //only when the checkbox is checked and the game isn't running                               
                map[mousePos[0], mousePos[1]] = 1; //changing the cell on the given mouse position
                panel1.Invalidate();    //"Updating" the panel
            }
            //Deleting Cells
            if(ErasecheckBox.Checked&&!gameStarted){    //the same as drawing just inverted
                map[mousePos[0], mousePos[1]] = 0;
                panel1.Invalidate();
            }                       
        }
        
        //Changing the state of the checkboxes so the aren't activated at the same time
        private void ErasecheckBox_CheckedChanged(object sender, EventArgs e)
        {
            DrawcheckBox.Checked = false;          
        }
        // -||- same -||-
        private void DrawcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ErasecheckBox.Checked = false;
        }

        //used for updating the values of the map 
        private void updateMapValues() {
            mapSize = 800 / (offset + tileSize);
            map = new int[mapSize, mapSize];
            newMap = new int[mapSize, mapSize];
            panel1.Invalidate();

            label6.Text = mapSize + "X" + mapSize;
            label1.Text = MapSizetrackBar.Value.ToString();
        }

        //function use for changing the map/tile -size with the trackbar
        private void MapSizetrackBar_Scroll(object sender, EventArgs e)
        {            
            tileSize = MapSizetrackBar.Value;
            updateMapValues();
        }
        
        //get's called when the GridFlag checkbox get's checked
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (GridFlag.Checked)
            {
                offset = 1;
            }
            else
            {
                offset = 0;
            }

            updateMapValues();
        }

        // array for storing the pattern that has to be shown
        static int[,] toShow;

        //function for drawing the patterns to the map
        void Pattern(String type) {
            
            int[,] Glider = new int[3, 3] { 
                {0,1,0},
                {0,0,1},
                {1,1,1}
            };

            int[,] Lwss = new int[4, 5] { 
                {0,1,0,0,1},
                {1,0,0,0,0},
                {1,0,0,0,1},
                {1,1,1,1,0}
            };

            int[,] _10cellRow = new int[1, 10]{
                {1,1,1,1,1,1,1,1,1,1}
            };

            int[,] Tumbler = new int[6, 7]{
                {0,1,1,0,1,1,0},
                {0,1,1,0,1,1,0},
                {0,0,1,0,1,0,0},
                {1,0,1,0,1,0,1},
                {1,0,1,0,1,0,1},
                {1,1,0,0,0,1,1}
            };

            int[,] Flower = new int[5, 5]{
                {1,0,1,0,1},
                {1,0,0,0,1},
                {1,0,0,0,1},
                {1,0,0,0,1},
                {1,0,1,0,1}
            };

            int[,] rp = new int[3, 3]{
                {0,1,1},
                {1,1,0},
                {0,1,0}
            };

            int[,] Diehard = new int[3, 8] { 
                {0,0,0,0,0,0,1,0},
                {1,1,0,0,0,0,0,0},
                {0,1,0,0,0,1,1,1}
            };

            int[,] Acorn = new int[3,7]{
                {0,1,0,0,0,0,0},
                {0,0,0,1,0,0,0},
                {1,1,0,0,1,1,1}
            };

            int[,] GGgun = new int[9,36] {
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,1,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,1,1,0,0,0,0,0,0,1,1,0,0,0,0,0,0,0,0,0,0,0,0,1,1},
                {0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,1,1,0,0,0,0,0,0,0,0,0,0,0,0,1,1},
                {1,1,0,0,0,0,0,0,0,0,1,0,0,0,0,0,1,0,0,0,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {1,1,0,0,0,0,0,0,0,0,1,0,0,0,1,0,1,1,0,0,0,0,1,0,1,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,1,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
            };

            switch (type) { 
                case "Glider":
                    toShow = Glider; break;

                case "LWSS":
                    toShow = Lwss; break;

                case "10 Cell Row":
                    toShow = _10cellRow; break;

                case "Tumbler":
                    toShow = Tumbler; break;
                
                case "Flower":
                    toShow = Flower; break;

                case "R-pentomino":
                    toShow = rp; break;

                case "Diehard":
                    toShow = Diehard; break;
                
                case "Acorn":
                    toShow = Acorn; break;

                case "Gosip Glider Gun":
                    if (mapSize > 35)
                    {
                        toShow = GGgun; break;
                    }
                    else{
                        MessageBox.Show("The map size should be bigger than 35X35"); 
                        toShow = Glider;
                        PatternComboBox.SelectedItem = "Glider";
                        break;
                    }
                    
            };
                                    
            for (int i = 0; i < toShow.GetLength(0); i++)
            {
                for (int j = 0; j < toShow.GetLength(1); j++)
                {
                    map[i + (mapSize/2)-toShow.GetLength(0)/2, j + (mapSize/2)-toShow.GetLength(1)/2] = toShow[i,j];//this shit here get's out of range
                }
            }                        
        }

        //function which is draws the patterns depenting on the combobox value
        private void PatterncomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RandomMapcheckBox.Checked = false;
            CavecheckBox.Checked = false;

            RandomMapcheckBox.Enabled = false;
            CavecheckBox.Enabled = false;

            string type = PatternComboBox.SelectedItem.ToString();
            ResetMap();
            Pattern(type);                    
            panel1.Invalidate();           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (CavecheckBox.Checked)
            {
                generateCave = true;
                RandomMapcheckBox.Checked = true;
            }
            else if (!CavecheckBox.Checked)
            {
                generateCave = false;
            }
        }
                                    
    }
}
