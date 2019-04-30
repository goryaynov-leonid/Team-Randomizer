using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
namespace Randomizer
{
    public partial class CSD_Randomizer : Form
    {
        public CSD_Randomizer()
        {
            InitializeComponent();
        }

        private void GenerateButtonClick(object sender, EventArgs e)
        {
            teamTextBox.Text = "";
            if (personTextBox.Text.Length == 0 || teamCountTextBox.Text.Length == 0)
            {
                return;
            }
            List<string[]> input = new List<string[]>();

            foreach (var item in personTextBox.Text.Split('\n'))
            {
                string a = item;
                if (a.IndexOf('\r') != -1)
                {
                    int h = a.IndexOf('\r');
                    a = a.Remove(h, 1);
                }
                if (item.Length > 0)
                {
                    input.Add(a.Split(' ', '\t'));
                }
            }

            int studentCount = input.Count;
            input.Sort((x, y) => Convert.ToDouble(x.Last()).CompareTo(Convert.ToDouble(y.Last())));
            int teamsCount;
            Int32.TryParse(teamCountTextBox.Text, out teamsCount);
            Random rand = new Random();
            List<List<string[]>> teams = new List<List<string[]>>();
            for (int i = 0; i < teamsCount; i++)
                teams.Add(new List<string[]>());
            int n = studentCount;
            int k = 1;
            while (n > 0)
            {
                int j = teamsCount;
                while (j > 0 && n > 0)
                {
                    int i = rand.Next(teamsCount);
                    if (teams[i].Count < k)
                    {
                        teams[i].Add(input[0]);
                        input.RemoveAt(0);
                        j--;
                        n--;
                    }
                }
                k++;
            }

            for (int i = 0; i < teams.Count; i++)
            {
                teamTextBox.Text += $"Team {i} ({teams[i].Sum(x => Convert.ToDouble(x.Last())).ToString()})\r\n";
                for (int j = 0; j < teams[i].Count; j++)
                {
                    for (int z = 0; z < teams[i][j].Length - 1; z++)
                    {
                        teamTextBox.Text += $"{teams[i][j][z]}  ";
                    }
                    teamTextBox.Text += "\r\n";
                }
                teamTextBox.Text += "\r\n";
            }
        }

        private void CSD_Randomizer_Load(object sender, EventArgs e)
        {

        }
    }
}
