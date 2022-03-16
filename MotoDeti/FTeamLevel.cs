using CustomControls.RJControls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MotoDeti
{
    public partial class FTeamLevel : Form
    {
        MobileControl mc;
        private LevelData _lvl;
        private bool disabled = false;

        public event EventHandler<AnswerEventArgs> Answer;
        public event EventHandler<SocketAnswerEventArgs> SocketAnswer;

        public LevelData Level
        {
            get => _lvl;
            set
            {
                _lvl = value;
                RefreshControls();
            }
        }

        public FTeamLevel()
        {
            InitializeComponent();
        }

        public void SetSocket(MobileControl mc)
        {
            this.mc = mc;
            mc.AnswerReceived += Mc_AnswerReceived;
        }

        public void SetLevel(LevelData lvl)
        {
            btn_a.Visible = true;
            btn_b.Visible = true;
            btn_a.Enabled = true;
            btn_b.Enabled = true;
            pb_a_answer.Visible = false;
            pb_b_answer.Visible = false;

            Level = lvl;
        }

        private void RefreshDescription()
        {
            lvl_description.Text = _lvl.description;
        }

        private void RefreshImages()
        {
            pb_a.BackgroundImage = _lvl.a_img;
            pb_b.BackgroundImage = _lvl.b_img;
        }

        private void RefreshControls()
        {
            RefreshDescription();
            RefreshImages();
        }

        private void Mc_AnswerReceived(object sender, MobileCOntrolEventArgs e)
        {
            if (disabled) return;
            var address = e.Address;
            var answer = e.Args[0].ToUpper();
            this.Invoke(new MethodInvoker(() =>
            {
                if (answer == "A" || answer == "B")
                {
                    var args = new SocketAnswerEventArgs()
                    {
                        Address = address,
                        Correct = SetAnswer(answer[0]),
                        Team = ""
                    };
                    SocketAnswer?.Invoke(this, args);
                    ShowResultForm(args.Team);
                }
            }));
        }

        private void btn_b_MouseEnter(object sender, EventArgs e)
        {
            btn_b.BackgroundImage = Properties.Resources.кнопка_б_hover;
            btn_b.BackColor = Color.Transparent;
            btn_b.BackgroundColor = Color.Transparent;
            btn_b.BorderColor = Color.Transparent;
            btn_b.ForeColor = Color.Transparent;
        }

        private void btn_b_MouseLeave(object sender, EventArgs e)
        {
            btn_b.BackgroundImage = Properties.Resources.кнопка_б;
        }

        private void btn_a_MouseEnter(object sender, EventArgs e)
        {
            btn_a.BackgroundImage = Properties.Resources.кнопка_а_hover;
            btn_a.BackColor = Color.Transparent;
            btn_a.BackgroundColor = Color.Transparent;
            btn_a.BorderColor = Color.Transparent;
            btn_a.ForeColor = Color.Transparent;
        }

        private void btn_a_MouseLeave(object sender, EventArgs e)
        {
            btn_a.BackgroundImage = Properties.Resources.кнопка_а;
        }

        private bool CheckCorrectAnswer(char answer)
        {
            return _lvl.correct_ans == answer;
        }

        private void btn_a_MouseClick(object sender, MouseEventArgs e)
        {
            if (disabled) return;
            if (e.Button == MouseButtons.Left)
            {
                // p1 A
                var args = new AnswerEventArgs()
                {
                    Player = "Player1",
                    Correct = SetAnswer('A'),
                    Team = ""
                };
                Answer?.Invoke(this, args);
                ShowResultForm(args.Team);
            } else if (e.Button == MouseButtons.Right)
            {
                // p2 A
                var args = new AnswerEventArgs()
                {
                    Player = "Player2",
                    Correct = SetAnswer('A'),
                    Team = ""
                };
                Answer?.Invoke(this, args);
                ShowResultForm(args.Team);
            }
        }

        private void btn_b_MouseClick(object sender, MouseEventArgs e)
        {
            if (disabled) return;
            if (e.Button == MouseButtons.Left)
            {
                // p1 B
                var args = new AnswerEventArgs()
                {
                    Player = "Player1",
                    Correct = SetAnswer('B'),
                    Team = ""
                };
                Answer?.Invoke(this, args);
                ShowResultForm(args.Team);
            }
            else if (e.Button == MouseButtons.Right)
            {
                // p2 B
                var args = new AnswerEventArgs()
                {
                    Player = "Player2",
                    Correct = SetAnswer('B'),
                    Team = ""
                };
                Answer?.Invoke(this, args);
                ShowResultForm(args.Team);
            }
        }


        private void FTeamLevel_KeyUp(object sender, KeyEventArgs e)
        {
            if (disabled) return;
            var key = e.KeyData;

            switch (key)
            {
                case Keys.Q:
                    {
                        // p1 A
                        var args = new AnswerEventArgs()
                        {
                            Player = "Player1",
                            Correct = SetAnswer('A'),
                            Team = ""
                        };
                        Answer?.Invoke(this, args);
                        ShowResultForm(args.Team);
                        break;
                    }
                case Keys.W:
                    {
                        // p1 B
                        var args = new AnswerEventArgs()
                        {
                            Player = "Player1",
                            Correct = SetAnswer('B'),
                            Team = ""
                        };
                        Answer?.Invoke(this, args);
                        ShowResultForm(args.Team);
                        break;
                    }
                case Keys.O:
                    {
                        // p2 A
                        var args = new AnswerEventArgs()
                        {
                            Player = "Player2",
                            Correct = SetAnswer('A'),
                            Team = ""
                        };
                        Answer?.Invoke(this, args);
                        ShowResultForm(args.Team);
                        break;
                    }
                case Keys.P:
                    {
                        // p2 B
                        var args = new AnswerEventArgs()
                        {
                            Player = "Player2",
                            Correct = SetAnswer('B'),
                            Team = ""
                        };
                        Answer?.Invoke(this, args);
                        ShowResultForm(args.Team);
                        break;
                    }
            }
        }

        private bool SetAnswer(char answer)
        {
            RJButton btn;
            PictureBox pb;
            if (answer == 'A')
            {
                btn = btn_a;
                pb = pb_a_answer;
            }
            else if (answer == 'B')
            {
                btn = btn_b;
                pb = pb_b_answer;
            }
            else return false;

            var correct = CheckCorrectAnswer(answer);
            btn_a.Enabled = false;
            btn_b.Enabled = false;
            btn.Visible = false;
            pb.Visible = true;
            pb.BackgroundImage = correct ? Properties.Resources.correct_answer : Properties.Resources.incorrect_answer;

            return correct;
        }

        private void ShowResultForm(string team)
        {
            disabled = true;
            resultPanel.Visible = true;
            teamName.Text = team;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FTeamLevel_FormClosed(object sender, FormClosedEventArgs e)
        {
            mc.Destroy();
        }

    }
}
