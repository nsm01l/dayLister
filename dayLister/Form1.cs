using System;
using System.Windows.Forms;

namespace dayLister
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 初期化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // 初期値指定
            weekStart.SelectedItem = "月";
            weekEnd.SelectedItem = "金";
        }

        /// <summary>
        /// 生成ボタンを押したら日付一覧を生成する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGen_Click(object sender, EventArgs e)
        {
            // 開始日時と終了日時の取得
            DateTime st = dateStart.Value;
            DateTime ed = dateEnd.Value;

            // 開始曜日と終了曜日の数値化
            int weekStartIndex = weekStart.SelectedIndex;
            int weekEndIndex = weekEnd.SelectedIndex;

            if (weekStartIndex == weekEndIndex)
            {
                txtGen.Text = "開始週と終了週が同じです";
                return;
            }

            // 曜日の範囲を数値化
            // 表示する範囲の幅
            int rangeWeek = (weekStartIndex < weekEndIndex) ? weekEndIndex - weekStartIndex : (7 - weekEndIndex) + weekStartIndex;
            // 次に行くためのステップ
            int nextStepWeek = (weekEndIndex > weekStartIndex) ? (7 - weekEndIndex) + weekStartIndex : weekStartIndex - weekEndIndex;

            // 開始日時の曜日を揃える
            DateTime counter;
            int stWeek = Convert.ToInt32(st.DayOfWeek); // 開始日の曜日

            // 生成文字列
            string txt = "";
            
            string fmt2Day = txtFormatRange.Text;
            string fmt1Day = txtFormatOneday.Text;

            // 開始日優先ならば、開始曜日にかかわらず表示する
            if (chkIsLonger.Checked)
            {
                DateTime tmp;
                if (weekEndIndex > stWeek)
                {
                    tmp = st.AddDays(weekEndIndex - stWeek);
                    txt += formatString(fmt2Day, st, tmp);
                }
                else if (stWeek > weekEndIndex)
                {
                    tmp = st.AddDays(7 - weekEndIndex + stWeek);
                    txt += formatString(fmt2Day, st, tmp);
                }
                else
                {
                    tmp = new DateTime(st.Year, st.Month, st.Day);
                    txt += formatString(fmt1Day, st);
                }
            }

            // ループの開始日を設定
            if (weekStartIndex > stWeek)
            {
                counter = st.AddDays(weekStartIndex - stWeek);
            }
            else if (weekStartIndex < stWeek)
            {
                counter = st.AddDays(7 - stWeek + weekStartIndex);
            }
            else
            {
                counter = new DateTime(st.Year, st.Month, st.Day);
            }
            
            // 一覧の生成
            DateTime next = counter.AddDays(+rangeWeek);    // 末尾
            while (next < ed || isSameDate(next, ed))
            {
                txt += formatString(fmt2Day, counter, next);
                // 開始日時の曜日を揃える
                counter = next.AddDays(+nextStepWeek);
                next = counter.AddDays(+rangeWeek);
            }

            // 終了日優先ならば、終了曜日にかかわらず表示する
            if (chkIsLonger.Checked)
            {
                if (counter < ed)
                {
                    txt += formatString(fmt2Day, counter, ed);
                }
                else if (isSameDate(counter, ed))
                {
                    txt += formatString(fmt1Day, counter);
                }
            }
            txtGen.Text = txt.TrimEnd();
        }

        // txtGen がダブルクリックされたら全選択する
        private void txtGen_DoubleClick(object sender, EventArgs e)
        {
            txtGen.SelectAll();
        }

        // 2 つの年月日が等しいか調べる
        static private Boolean isSameDate(DateTime a, DateTime b)
        {
            return (a.Year == b.Year && a.Month == b.Month && a.Day == b.Day);
        }

        /// <summary>
        /// 書式に応じて文字列を出力する
        /// </summary>
        /// <param name="fmt"></param>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
        static private string formatString(string fmt, DateTime d1, DateTime d2)
        {
            // %md*%
            fmt = fmt.Replace("%md1%", d1.Month + "/" + d1.Day);
            fmt = fmt.Replace("%md2%", d2.Month + "/" + d2.Day);
            // %ymd+%
            fmt = fmt.Replace("%ymd1%", d1.Year + "/" + d1.Month + "/" + d1.Day);
            fmt = fmt.Replace("%ymd2%", d2.Year + "/" + d2.Month + "/" + d2.Day);
            // %y*%
            fmt = fmt.Replace("%y1%", d1.Year.ToString());
            fmt = fmt.Replace("%y2%", d2.Year.ToString());
            // %m*%
            fmt = fmt.Replace("%m1%", d1.Month.ToString());
            fmt = fmt.Replace("%m2%", d2.Month.ToString());
            // %d*%
            fmt = fmt.Replace("%d1%", d1.Day.ToString());
            fmt = fmt.Replace("%d2%", d2.Day.ToString());

            return fmt + "\r\n";
        }

        /// <summary>
        /// 書式の定義
        /// </summary>
        /// <param name="fmt"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        static private string formatString(string fmt, DateTime d)
        {
            // %md%
            fmt = fmt.Replace("%md%", d.Month + "/" + d.Day);
            // %ymd%
            fmt = fmt.Replace("%ymd%", d.Year + "/" + d.Month + "/" + d.Day);
            // %y%
            fmt = fmt.Replace("%y%", d.Year.ToString());
            // %m%
            fmt = fmt.Replace("%m%", d.Month.ToString());
            // %d%
            fmt = fmt.Replace("%d%", d.Day.ToString());

            return fmt + "\r\n";
        }
    }
}
