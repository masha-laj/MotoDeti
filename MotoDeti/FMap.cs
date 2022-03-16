using CustomControls.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotoDeti
{
    

    public partial class FMap : Form
    {
        private GameDB db = GameDB.getInstance();
        private GameInfo _gameInfo;

        public GameInfo GameInfo
        {
            get => _gameInfo;
            set
            {
                _gameInfo = value;
                RefreshButtons();
            }
        }

        private FLevel levelForm = new FLevel();
        private int LVL_COUNT = 10;
        private int _currentLvl = 0;

        public FMap()
        {
            InitializeComponent();

            levelForm.Owner = this;
        }

        private RJButton FindLvlBtn(int level)
        {
            var ctrls = Controls.Find($"btn{level}", false);

            if (ctrls.Length == 0) return null;

            return ctrls[0] as RJButton;
        }

        private void SetLvlBtnEnabled(int level, bool enabled)
        {
            var btn = FindLvlBtn(level);
            if (btn == null) return;

            if (enabled)
            {
                btn.Enabled = true;
            } else
            {
                btn.Enabled = false;
            }
        }

        private void SetLvlBtnState(int level, int state)
        {
            var btn = FindLvlBtn(level);
            if (btn == null) return;

            if (state == 1)
            {
                btn.BackgroundColor = Color.Green;
            } else if (state == -1)
            {
                btn.BackgroundColor = Color.Red;
            } else
            {
                btn.BackgroundColor = Color.White;
            }
        }

        private void RefreshButtons()
        {
            for (int i = 1; i <= LVL_COUNT; i++)
            {
                SetLvlBtnEnabled(i, i <= GameInfo.lastLevel + 1);

                if (GameInfo.levelsProgress.ContainsKey(i))
                {
                    SetLvlBtnState(i, GameInfo.levelsProgress[i].state);
                }
                else
                {
                    SetLvlBtnState(i, -2);
                }
            }
        }

        private void SelectLevel(object sender, EventArgs e)
        {
            var name = (sender as Button).Name;
            var lvl = int.Parse(name.Substring(name.IndexOf("btn") + 3));

            OpenLevel(lvl);
        }

        private void OpenLevel(int lvl)
        {
            if (levelForm == null || levelForm.IsDisposed)
            {
                levelForm = new FLevel();
                levelForm.Owner = this;
            }
            _currentLvl = lvl;
            levelForm.SetGameInfo(GameInfo);
            levelForm.SetLevel(lvl, levels[lvl], GameInfo.levelsProgress.ContainsKey(lvl) ? GameInfo.levelsProgress[lvl] : default);

            levelForm.Show();
        }

        public void NextLevel()
        {
            if (_currentLvl + 1 > LVL_COUNT) return;
            if (levelForm == null || levelForm.IsDisposed)
            {
                levelForm = new FLevel();
                levelForm.Owner = this;
            }
            _currentLvl++;
            GameInfo.SetLastLevel(_currentLvl);
            SaveGame();
            levelForm.SetLevel(_currentLvl, levels[_currentLvl], GameInfo.levelsProgress.ContainsKey(_currentLvl) ? GameInfo.levelsProgress[_currentLvl] : default);
        }

        public void SetLevelProgress(int state, int timeleft)
        {
            var lvlProgress = new LevelProgress { state = state, timeleft = timeleft };
            if (GameInfo.levelsProgress.ContainsKey(_currentLvl))
            {
                GameInfo.levelsProgress[_currentLvl] = lvlProgress;
            } else {
                GameInfo.levelsProgress.Add(_currentLvl, lvlProgress);
            }

            var ended = lvlProgress.state != 0 || Properties.Settings.Default.answertime_single - lvlProgress.timeleft <= 0;

            if (ended && _currentLvl + 1 > GameInfo.lastLevel)
            {
                GameInfo.SetLastLevel(_currentLvl);
            }
            SaveGame();
            RefreshButtons();
        }

        public void LostLive()
        {
            GameInfo.lives--;
            if (GameInfo.lives <= 0)
            {
                GameInfo.SetLastLevel(_currentLvl - 1);
                RefreshButtons();
            }
            SaveGame();
        }

        public bool HasNextLevel()
        {
            return _currentLvl + 1 <= 10;
        }

        public void SaveGame()
        {
            db.SaveGame(GameInfo);
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            var Form = new FMenuMap();
            if (Form.ShowDialog() == DialogResult.OK)
            {
                Close();
            }
        }
    }
}
