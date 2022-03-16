using CustomControls.RJControls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MotoDeti
{
    public partial class FLevel : Form
    {
        private Timer _timer;
        private int _timeleft = 0;
        private int _lives = 0;
        private int _maxLives = 0;
        private bool _showTip = false;

        private int _timeToAnswer = 0;
        public int TimeToAnswer
        {
            get => _timeToAnswer;
            set
            {
                _timeToAnswer = value;
            }
        }

        public int TimeLeft
        {
            get => _timeleft;
            set
            {
                _timeleft = value;
                RefreshTimerLabel();
            }
        }

        public int Lives
        {
            get => _lives;
            set
            {
                _lives = value;
                RefreshLivesLabel();
            }
        }
        public int MaxLives
        {
            get => _maxLives;
            set
            {
                _maxLives = value;
                RefreshLivesLabel();
            }
        }

        public bool ShowTip
        {
            get => _showTip;
            set
            {
                _showTip = value;
            }
        }

        private int _lvl = 0;

        public int Lvl
        {
            get => _lvl;
            set
            {
                _lvl = value;
                RefreshControls();
            }
        }

        private LevelData levelData;
        private int levelState = 0;

        public FLevel()
        {
            InitializeComponent();

            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Tick += _timer_Tick;

            toolTip1.SetToolTip(lives_lbl, "Осталось попыток");
            toolTip2.SetToolTip(timer_lbl, "Осталось времени");
        }

        public void SetGameInfo(GameInfo info)
        {
            Lives = info.lives;
            MaxLives = info.maxLives;
            TimeToAnswer = info.levelTime;
            ShowTip = info.showTip;
        }

        public void SetLevel(int lvl, LevelData lvlData, LevelProgress lvlProgress)
        {
            var ended = lvlProgress.state != 0 || TimeToAnswer - lvlProgress.timeleft <= 0;

            if (ended)
            {
                TimeLeft = TimeToAnswer - lvlProgress.timeleft;
            }
            else
            {
                TimeLeft = TimeToAnswer;
                _timer.Start();
            }

            if (ended)
            {
                btn_a.Visible = false;
                btn_b.Visible = false;
                btn_a.Enabled = false;
                btn_b.Enabled = false;

                if (lvlProgress.state == 1)
                {
                    if (lvlData.correct_ans == 'A')
                    {
                        pb_a_answer.Visible = true;
                        pb_a_answer.BackgroundImage = Properties.Resources.correct_answer;
                    } else if (lvlData.correct_ans == 'B')
                    {
                        pb_b_answer.Visible = true;
                        pb_b_answer.BackgroundImage = Properties.Resources.correct_answer;
                    }
                }
                else if (lvlProgress.state == -1)
                {
                    if (lvlData.correct_ans == 'A')
                    {
                        pb_b_answer.Visible = true;
                        pb_b_answer.BackgroundImage = Properties.Resources.incorrect_answer;
                    }
                    else if (lvlData.correct_ans == 'B')
                    {
                        pb_a_answer.Visible = true;
                        pb_a_answer.BackgroundImage = Properties.Resources.incorrect_answer;
                    }
                }
            }
            else
            {
                btn_a.Visible = true;
                btn_b.Visible = true;
                btn_a.Enabled = true;
                btn_b.Enabled = true;
                pb_a_answer.Visible = false;
                pb_b_answer.Visible = false;
            }
            next_btn.Visible = false;

            levelData = lvlData;
            Lvl = lvl;
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            TimeLeft--;
            if (TimeLeft <= 0)
            {
                var map = Owner as FMap;
                map?.SetLevelProgress(levelState, TimeToAnswer - _timeleft);
                _timer.Stop();
                btn_a.Enabled = false;
                btn_b.Enabled = false;
                Lives--;
                map.LostLive();
                if (map.HasNextLevel() && Lives > 0)
                {
                    next_btn.Visible = true;
                } else if (Lives == 0)
                {
                    MessageBox.Show("Game Over");
                }
            }
        }

        private void RefreshTimerLabel()
        {
            timer_lbl.Text = $"{TimeLeft}\nсек.";

            timer_lbl.ForeColor = TimeLeft == 0 ? Color.Red : Color.Black;
        }

        private void RefreshLivesLabel()
        {
            lives_lbl.Text = $"{Lives} / {MaxLives}";

            lives_lbl.ForeColor = Lives == 0 ? Color.Red : Color.Black;
        }

        private void RefreshDescription()
        {
            lvl_description.Text = levelData.description;
        }

        private void RefreshImages()
        {
            pb_a.BackgroundImage = levelData.a_img;
            pb_b.BackgroundImage = levelData.b_img;
        }

        private void RefreshControls()
        {
            RefreshDescription();
            RefreshImages();
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
            return levelData.correct_ans == answer;
        }

        private void btn_a_Click(object sender, EventArgs e)
        {
            SetAnswer('A');
        }

        private void btn_b_Click(object sender, EventArgs e)
        {
            SetAnswer('B');
        }

        private void SetAnswer(char answer)
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
            else return;

            var correct = CheckCorrectAnswer(answer);
            levelState = correct ? 1 : -1;

            _timer.Stop();
            btn_a.Enabled = false;
            btn_b.Enabled = false;
            btn.Visible = false;
            pb.Visible = true;
            pb.BackgroundImage = correct ? Properties.Resources.correct_answer : Properties.Resources.incorrect_answer;

            var map = Owner as FMap;
            map.SetLevelProgress(levelState, TimeToAnswer - _timeleft);
            if (!correct)
            {
                Lives--;
                map.LostLive();

                if (ShowTip && !string.IsNullOrEmpty(levelData.tip))
                {
                    var tipForm = new FLevelTip();
                    tipForm.SetTip(levelData.tip);
                    tipForm.ShowDialog();
                }
            }
            if (map.HasNextLevel() && Lives > 0)
            {
                next_btn.Visible = true;
            } else
            {
                if (Lives > 0)
                {
                    var topForm = new FTop();
                    topForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Game Over");
                }
            }
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            var map = Owner as FMap;
            map.NextLevel();
        }

        private void FLevel_FormClosing(object sender, FormClosingEventArgs e)
        {
            _timer.Stop();
        }
    }
}
