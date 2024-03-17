using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_star_8tasbulmacasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonsolve_Click(object sender, EventArgs e)
        {
            // Başlangıç durumu
            int[,] startMatrix = GetMatrixFromTextBoxes(textstart00, textstart01, textstart02, textstart10, textstart11, textstart12, textstart20, textstart21, textstart22);

            if (startMatrix == null)
                return;

            // Hedef durumu
            hedefmatrisform hedefForm = new hedefmatrisform();
            hedefForm.ShowDialog();
            int[,] goalMatrix = hedefForm.HedefMatris;

            if (goalMatrix == null)
                return;

            PuzzleState startState = new PuzzleState(startMatrix, hedefForm.EmptyTileRow, hedefForm.EmptyTileCol, new PuzzleState(goalMatrix, 0, 0, null));

            PuzzleSolver solver = new PuzzleSolver();
            List<PuzzleState> solution = solver.SolvePuzzleWithSteps(startState);

            if (solution != null)
            {
                ApplySolution(solution);
            }
            else
            {
                MessageBox.Show("Çözüm bulunamadı!");
            }
        }

        private void ApplySolution(List<PuzzleState> solution)
        {
            // Form üzerindeki TextBox'ları temizle
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = "";
                }
            }

            // Çözümü form üzerinde gösterme
            for (int i = 0; i < solution.Count; i++)
            {
                PuzzleState state = solution[i];
                int[,] matrix = state.Board;

                for (int row = 0; row < 3; row++)
                {
                    for (int col = 0; col < 3; col++)
                    {
                        // TextBox'ları güncelleme
                        string textBoxName = $"textstart{row}{col}";
                        TextBox textBox = Controls.Find(textBoxName, true).FirstOrDefault() as TextBox;
                        if (textBox != null)
                        {
                            textBox.Text = matrix[row, col].ToString();
                        }
                    }
                }

                // Her adımda bir saniye bekletme (opsiyonel)
                System.Threading.Thread.Sleep(1000);
                Application.DoEvents();
            }

            MessageBox.Show("Çözüm bulundu ve uygulandı!");
        }

        private int[,] GetMatrixFromTextBoxes(params TextBox[] textBoxes)
        {
            int[,] matrix = new int[3, 3];

            try
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (!int.TryParse(textBoxes[i * 3 + j].Text, out matrix[i, j]))
                        {
                            MessageBox.Show($"Geçersiz sayı girişi: {textBoxes[i * 3 + j].Text}");
                            return null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
                return null;
            }

            return matrix;
        }
    }
}
    

