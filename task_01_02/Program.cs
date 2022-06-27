using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_01_02
{
    // ���������������� �����
    class MyForm : Form
    {
        // ����������� ������
        public MyForm(string caption)
        {
            // ����� ��������� �����
            Text = caption;
        }
    }


    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // �������� ������� ����������������� ������ �����
            MyForm frm = new MyForm("Hello, world!!!");
            // ���������� ����� �� ����� ������������ 
            // ��� ����� �� ���������� ����� ��� ����������� ��������� ��������
            frm.ShowDialog();
        }
    }
}
