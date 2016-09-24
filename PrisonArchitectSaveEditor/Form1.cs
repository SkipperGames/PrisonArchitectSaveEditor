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
using Microsoft.VisualBasic.FileIO;

namespace PrisonArchitectSaveEditor
{
    public partial class Form1 : Form
    {
        string filename;
        List<string> lines;

        public Form1()
        {
            InitializeComponent();

            vScrollBar1.Scroll += (sender, e) => { panel1.VerticalScroll.Value = vScrollBar1.Value; };
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Prison Architect save (*.prison)|*.prison|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filename = dialog.FileName;
                lines = File.ReadAllLines(filename).ToList();
                toolStripStatusLabel1.Text = "Loaded";
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filename))
            {
                if (File.Exists(filename))
                {
                    File.WriteAllLines(filename, lines.ToArray());
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void b_unsuppress_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filename))
            {
                toolStripStatusLabel1.Text = "working";

                int numEmancipated = 0;

                for (int i = 0; i < lines.Count; i++)
                {
                    string line = lines[i];

                    if (line.Contains("BEGIN suppressed"))
                    {
                        lines.RemoveRange(i - 1, 3);
                    }
                    else if (line.Contains("Suppressed"))
                    {
                        int id = line.IndexOf("Suppressed") + 10;
                        while (line[id] == ' ') { id++; }
                        char[] arr = line.Skip(id).Take(8).ToArray();

                        float num = 0.000000f;
                        if (float.TryParse(new string(arr), out num))
                        {
                            lines[i] = line.Replace(new string(arr), "0.000000");
                            numEmancipated++;
                        }
                    }
                }

                toolStripStatusLabel1.Text = string.Format("unsuppressed {0} prisoners", numEmancipated);
            }
        }

        private void b_rechargetazers_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filename))
            {
                toolStripStatusLabel1.Text = "working";
                int numTazersRecharged = 0;

                for (int i = 0; i < lines.Count; i++)
                {
                    string line = lines[i];

                    if (line.Contains("TazerRecharge"))
                    {
                        int id = line.IndexOf("TazerRecharge") + 13;
                        while (line[id] == ' ') { id++; }
                        char[] arr = line.Skip(id).Take(8).ToArray();

                        float num = 0.000000f;
                        if (float.TryParse(new string(arr), out num))
                        {
                            lines[i] = line.Replace(new string(arr), "0.000000");
                            numTazersRecharged++;
                        }
                    }
                }

                toolStripStatusLabel1.Text = String.Format("recharged {0} tazers", numTazersRecharged);
            }
        }

        private void b_armtazers_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filename))
            {
                toolStripStatusLabel1.Text = "working";

                List<string> keywords = new List<string>();
                int numTazersGiven = 0;

                for (int i = 0; i < lines.Count; i++)
                {
                    if (lines[i].Contains("Type") && 
                        (lines[i].Contains("Guard") || lines[i].Contains("ArmedGuard")))
                    {
                        keywords.Clear();

                        for (string line = lines[i]; !line.Contains("END"); line = lines[i++])
                        {
                            keywords.Add(line);                            
                        }

                        if (keywords.All(s => !s.Contains("Tazer")))
                        {
                            lines.InsertRange(i - 1, new string[4]
                            {
                                "        Timer                0.000000  ",
                                "        SecondaryEquipment   Tazer  ",
                                "        Training             100.0000  ",
                                "        TazerTrained         true  "
                            });

                            i += 4;
                            numTazersGiven++;
                        }
                    }
                }

                toolStripStatusLabel1.Text = String.Format("armed {0} guards with new tazers", numTazersGiven);
            }
        }

        private void b_reputation_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filename))
            {
                toolStripStatusLabel1.Text = "working";

                for (int i = 0; i < lines.Count; i++)
                {
                    while (lines[i].Contains("Reputation") && !lines[i].Contains("FederalWitness"))
                    {
                        lines.RemoveAt(i);

                    }
                }

                toolStripStatusLabel1.Text = "removed reputations among prisoners";
            }
        }

        private void b_traits_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filename))
            {
                toolStripStatusLabel1.Text = "working";

                for (int i = 0; i < lines.Count; i++)
                {
                    while (lines[i].Contains("Traits"))
                    {
                        lines.RemoveAt(i);
                    }
                }

                toolStripStatusLabel1.Text = "removed traits from all prisoners";
            }
        }

        private void b_carpenters_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filename))
            {
                toolStripStatusLabel1.Text = "working";

                List<string> keywords = new List<string>(10);
                int numPrisonersTrained = 0;

                for (int i = 0; i < lines.Count; i++)
                {
                    if (lines[i].Contains("BEGIN") && lines[i].Contains("Results"))
                    {
                        keywords.Clear();

                        if (lines[i].Contains("END"))
                        {
                            lines[i] = lines[i].Replace("END", "");
                        }

                        i++;
                        while (lines[i].Contains("BEGIN"))
                        {
                            keywords.Add(lines[i]);
                            i++;
                        }

                        if (keywords.All(s => !s.Contains("WorkshopInduction")))
                        {
                            lines.InsertRange(i, new string[2]
                            {
                                "                BEGIN WorkshopInduction Passed 1  Attended 42514.585937500000  END",
                                "                BEGIN Carpentry  Passed 1  END"
                            });

                            i += 2;

                            if (keywords.Count == 0)
                            {
                                lines.Insert(i, "            END");
                            }

                            numPrisonersTrained++;
                        }
                    }
                }

                toolStripStatusLabel1.Text = String.Format("{0} prisoners are now carpenters", numPrisonersTrained);
            }
        }

        private void b_repair_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filename))
            {
                toolStripStatusLabel1.Text = "working";

                int numrepaired = 0;

                for (int i = 0; i < lines.Count; i++)
                {
                    string line = lines[i];

                    if (line.Contains("Damage"))
                    {
                        int id = line.IndexOf("Damage") + 6;
                        while (line[id] == ' ') { id++; }
                        char[] arr = line.Skip(id).Take(10).ToArray();

                        float num = 0.00000000f;
                        if (float.TryParse(new string(arr), out num))
                        {
                            lines[i] = line.Replace(new string(arr), "0.00000000");
                            numrepaired++;
                        }
                    }
                }

                toolStripStatusLabel1.Text = String.Format("repaired {0} objects", numrepaired);
            }
        }

        private void b_gangmembers_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filename))
            {
                toolStripStatusLabel1.Text = "working";

                for (int i = 0; i < lines.Count; i++)
                {
                    if (lines[i].Contains("Gang.Id"))
                    {
                        lines.RemoveRange(i, 3);
                    }
                }

                toolStripStatusLabel1.Text = "no more gang members";
            }
        }

        private void b_reoffend_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filename))
            {
                toolStripStatusLabel1.Text = "working";

                int numPrisonersFixed = 0;

                for (int i = 0; i < lines.Count; i++)
                {
                    if (lines[i].Contains("StartingReoffendingChance"))
                    {
                        lines[i] = "            StartingReoffendingChance 0  ";
                        numPrisonersFixed++;
                    }
                }

                toolStripStatusLabel1.Text = String.Format("{0} prisoners have zero starting reoffending chance", numPrisonersFixed);
            }
        }
    }
}
