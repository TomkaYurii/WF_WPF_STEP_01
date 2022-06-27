using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_01_04
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            static DialogResult ShowMessageBoxes()
            {
                //����� ����, ������������� ��������� ��������� � ������ ��
                String message = "����, ������������ ��������� ���������";
                MessageBox.Show(message);

                //����� ���� � ������� � ����� �������� OK � CANCEL
                message = "���� � ������� � ����� �������� OK � CANCEL";
                String caption = "���� � ����� ��������";
                DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.OKCancel);
                String button = result.ToString();

                //����� ���� � ����� �������� � �����-�� �������
                result = MessageBox.Show("�� ������ ������ " + button + ". ���������?", button, MessageBoxButtons.AbortRetryIgnore,
                                MessageBoxIcon.Asterisk);
                return result;
            }

            DialogResult result;
            do 
            {
                result = ShowMessageBoxes();
            } while (result == DialogResult.Retry);

            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
