using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GladiatorsWindows
{
    public static class Prompt
    {
        /// <summary>
        /// Shows question to the user
        /// </summary>
        /// <param name="question"></param>
        /// <param name="promptName"></param>
        /// <returns></returns>
        public static string ShowQuestion(string question, string promptName, string defaultResponse)
        {
            
            Form prompt = new Form()
            {
                Height = 150,
                Width = 400,
                Text = promptName,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterScreen

            };
            
            Label labelQuestion = new Label()
            {
                Left = 40,
                Top = 10,
                Width = 320,
                Text = question
            };

            TextBox textBoxAnswer = new TextBox()
            {
                Left = 40,
                Top = 40,
                Width = 320
            };

            Button buttonConfirm = new Button()
            {
                Left = 250,
                Top = 70,
                Width = 100,
                Text = "Confirm",
                DialogResult = DialogResult.OK
            };

            buttonConfirm.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBoxAnswer);
            prompt.Controls.Add(buttonConfirm);
            prompt.Controls.Add(labelQuestion);
            prompt.AcceptButton = buttonConfirm;

            return prompt.ShowDialog() == DialogResult.OK ? textBoxAnswer.Text : defaultResponse;
        }
    }
}
