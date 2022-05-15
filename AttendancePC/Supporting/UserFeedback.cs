using System;
using System.Data;
using System.Windows.Forms;

namespace AttendancePC.Supporting
{
    public static class UserFeedback
    {
        public static void ErrorMessage(Exception ex = null)
        {
            if (ex == null)
            {
                MessageBox.Show("Возникла непредвиденная ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ex is DataException)
            {
                MessageBox.Show("При работе с данными возникла ошибка, попробуйте снова. " +
                    "Если ошибка не исчезнет, обратитесь к администратору приложения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void InformationMessage(string message)
        {
            MessageBox.Show(message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool QuestionMessage(string message)
        {
            return MessageBox.Show(message, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }
    }
}
