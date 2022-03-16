using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MotoDeti
{
    public struct LevelData
    {
        public string description;
        public Bitmap a_img;
        public Bitmap b_img;
        public char correct_ans;
        public string tip;
    }

    public static class LvlsCreator
    {
        public static Dictionary<int, LevelData> Levels()
        {
            return new Dictionary<int, LevelData>()
        {
            { 1, new LevelData
            {
                description = "ЧЕМ ДОЛЖНЫ РУКОВОДСТВОВАТЬСЯ УЧАСТНИКИ ДОРОЖНОГО ДВИЖЕНИЯ?",
                a_img = Properties.Resources._1_1,
                b_img = Properties.Resources._1_2,
                correct_ans = 'A',
                tip = "Подсказка 1"
            } },
            { 2, new LevelData
            {
                description = "КАК ПЕРЕЙТИ ДОРОГУ НА ВЕЛОСИПЕДЕ?",
                a_img = Properties.Resources._2_1,
                b_img = Properties.Resources._2_2,
                correct_ans = 'B',
                tip = "Подсказка 2"
            } },
            { 3, new LevelData
            {
                description = "ЕСЛИ ВЫ ИДЕТЕ В КАПЮШОНЕ, НУЖНО ЛИ ЕГО СНИМАТЬ, ЧТО БЫ ПЕРЕЙТИ ДОРОГУ?",
                a_img = Properties.Resources._3_1,
                b_img = Properties.Resources._3_2,
                correct_ans = 'B'
            } },
            { 4, new LevelData
            {
                description = "ЕСЛИ ВЫ ГОВОРИТЕ ПО ТЕЛЕФОНУ ИЛИ ЧИТАЕТЕ СООБЩЕНИЯ В СОЦСЕТЯХ, НУЖНО ЛИ УБРАТЬ ТЕЛЕФОН ПЕРЕД ПЕРЕХОДОМ ПРОЕЗЖЕЙ ЧАСТИ?",
                a_img = Properties.Resources._4_1,
                b_img = Properties.Resources._4_2,
                correct_ans = 'B'
            } },
            { 5, new LevelData
            {
                description = "У РЕБЕНКА УПАЛА НА ДОРОГУ ИГРУШКА, ВЫЛЕТЕЛ МЯЧ, КАК ПРАВИЛЬНО ПОСТУПИТЬ?",
                a_img = Properties.Resources._5_1,
                b_img = Properties.Resources._5_2,
                correct_ans = 'B'
            } },
            { 6, new LevelData
            {
                description = "ГДЕ МОЖНО ЕЗДИТЬ РЕБЕНКУ ДО 7 ЛЕТ НА ВЕЛОСИПЕДЕ?",
                a_img = Properties.Resources._6_2,
                b_img = Properties.Resources.Общий_опросник,
                correct_ans = 'B'
            } },
            { 7, new LevelData
            {
                description = "С КАКОГО ВОЗРАСТА РЕБЕНОК МОЖЕТ ВЫЕЗЖАТЬ НА ДОРОГУ ОБЩЕГО ПОЛЬЗОВАНИЯ НА ВЕЛОСИПЕДЕ?",
                a_img = Properties.Resources._7_1,
                b_img = Properties.Resources._7_2,
                correct_ans = 'B'
            } },
            { 8, new LevelData
            {
                description = "КАК ПЕРЕВОЗИТЬ РЕБЕНКА ДО 7 ЛЕТ НА ВЕЛОСИПЕДЕ?",
                a_img = Properties.Resources._8_1,
                b_img = Properties.Resources._8_2,
                correct_ans = 'B'
            } },
            { 9, new LevelData
            {
                description = "КАК ДОЛЖЕН ПЕРЕДВИГАТЬСЯ РЕБЕНОК В АВТОМОБИЛЕ ЕСЛИ ЕМУ НЕ ИСПОЛНИЛОСЬ 7 ЛЕТ?",
                a_img = Properties.Resources._9_1,
                b_img = Properties.Resources._9_2,
                correct_ans = 'B'
            } },
            { 10, new LevelData
            {
                description = "ЧТО УЧИТ РЕБЕНКА ПРАВИЛАМ ПОВЕДЕНИЯ НА ДОРОГЕ ЛУЧШЕ?",
                a_img = Properties.Resources._10_1,
                b_img = Properties.Resources._10_2,
                correct_ans = 'A'
            } }
        };
        }
    }

    public partial class FMap : Form
    {
        private Dictionary<int, LevelData> levels = LvlsCreator.Levels();
    }
}
