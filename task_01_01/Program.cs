using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_01_01
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // �������� ������� ������ �����
            Form frm = new Form();
            // ����� ��������� �����
            frm.Text = "First Windows Forms application";
            // ���������� ����� �� ����� ������������ 
            // ��� ����� �� ���������� ����� ��� ����������� ��������� ��������
            frm.ShowDialog();


        }
    }
}
