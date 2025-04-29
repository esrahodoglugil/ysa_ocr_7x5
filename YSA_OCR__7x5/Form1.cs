using System;
using System.Drawing;
using System.Windows.Forms;

namespace YSA_OCR__7x5
{
    public partial class Form1 : Form
    {
        private Button[,] matrixButtons = new Button[7, 5];
        private int[] inputVector = new int[35];
        private NeuralNetwork network;
        private int[,,] egitim;
        private int[,] istenenCikti;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeMatrixButtons();

            // Eðitim verisi
            egitim = new int[5, 7, 5]
            {
                {
                    {0,0,1,0,0},
                    {0,1,0,1,0},
                    {1,0,0,0,1},
                    {1,0,0,0,1},
                    {1,1,1,1,1},
                    {1,0,0,0,1},
                    {1,0,0,0,1}
                },
                {
                    {1,1,1,1,0},
                    {1,0,0,0,1},
                    {1,0,0,0,1},
                    {1,1,1,1,0},
                    {1,0,0,0,1},
                    {1,0,0,0,1},
                    {1,1,1,1,0}
                },
                {
                    {0,0,1,1,1},
                    {0,1,0,0,0},
                    {1,0,0,0,0},
                    {1,0,0,0,0},
                    {1,0,0,0,0},
                    {0,1,0,0,0},
                    {0,0,1,1,1}
                },
                {
                    {1,1,1,0,0},
                    {1,0,0,1,0},
                    {1,0,0,0,1},
                    {1,0,0,0,1},
                    {1,0,0,0,1},
                    {1,0,0,1,0},
                    {1,1,1,0,0}
                },
                {
                    {1,1,1,1,1},
                    {1,0,0,0,0},
                    {1,0,0,0,0},
                    {1,1,1,1,1},
                    {1,0,0,0,0},
                    {1,0,0,0,0},
                    {1,1,1,1,1}
                }
            };

            istenenCikti = new int[5, 5]
            {
                {1,0,0,0,0}, // A
                {0,1,0,0,0}, // B
                {0,0,1,0,0}, // C
                {0,0,0,1,0}, // D
                {0,0,0,0,1}  // E
            };

            int hiddenNeurons = (int)numHiddenNeurons.Value;
            double learningRate = double.Parse(txtLearningRate.Text.Replace(",", "."));

            network = new NeuralNetwork(35, hiddenNeurons, 5, learningRate);
        }

        private void InitializeMatrixButtons()
        {
            int buttonSize = 40;
            int spacing = 2;

            for (int row = 0; row < 7; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(buttonSize, buttonSize);
                    btn.Location = new Point(col * (buttonSize + spacing), row * (buttonSize + spacing));
                    btn.BackColor = Color.White;
                    btn.Tag = new Point(row, col);
                    btn.Click += MatrixButton_Click;

                    matrixButtons[row, col] = btn;
                    panel1.Controls.Add(btn);
                }
            }
        }

        private void MatrixButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            Point location = (Point)clickedButton.Tag;
            int index = location.X * 5 + location.Y;

            if (clickedButton.BackColor == Color.White)
            {
                clickedButton.BackColor = Color.Black;
                inputVector[index] = 1;
            }
            else
            {
                clickedButton.BackColor = Color.White;
                inputVector[index] = 0;
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrixButtons[i, j].BackColor = Color.White;
                    inputVector[i * 5 + j] = 0;
                }
            }
        }

        private void btnCizgileriKaldir_Click(object sender, EventArgs e)
        {
            foreach (Button btn in matrixButtons)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
            }
        }

        private void btnEgit_Click(object sender, EventArgs e)
        {
            // BU BLOÐU YAPIÞTIR
            double totalError = 0;

            for (int epoch = 0; epoch < 1000; epoch++)
            {
                for (int h = 0; h < 5; h++)
                {
                    double[] input = new double[35];
                    for (int i = 0; i < 7; i++)
                        for (int j = 0; j < 5; j++)
                            input[i * 5 + j] = egitim[h, i, j];

                    double[] target = new double[5];
                    for (int k = 0; k < 5; k++)
                        target[k] = istenenCikti[h, k];

                    totalError += network.Train(input, target);
                }
            }

            lblHataOrani.Text = $"Hata Oraný: {totalError:F4}";
            MessageBox.Show("Eðitim tamamlandý!");
        }


        private void btnTanimla_Click(object sender, EventArgs e)
        {
            double[] input = Array.ConvertAll(inputVector, x => (double)x);
            double[] output = network.Predict(input);

            lblOutputA.Text = $"A: {output[0]:F3}";
            lblOutputB.Text = $"B: {output[1]:F3}";
            lblOutputC.Text = $"C: {output[2]:F3}";
            lblOutputD.Text = $"D: {output[3]:F3}";
            lblOutputE.Text = $"E: {output[4]:F3}";

            // En büyük deðeri yeþil renkle vurgula
            lblOutputA.ForeColor = lblOutputB.ForeColor = lblOutputC.ForeColor =
            lblOutputD.ForeColor = lblOutputE.ForeColor = Color.Black;

            int maxIndex = Array.IndexOf(output, output.Max());
            switch (maxIndex)
            {
                case 0: lblOutputA.ForeColor = Color.Green; break;
                case 1: lblOutputB.ForeColor = Color.Green; break;
                case 2: lblOutputC.ForeColor = Color.Green; break;
                case 3: lblOutputD.ForeColor = Color.Green; break;
                case 4: lblOutputE.ForeColor = Color.Green; break;
            }
        }


    }
}
