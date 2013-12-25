namespace 二维码生成
{
    using System;
    using System.Threading;
    using System.Windows.Forms;

    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            bool flag;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Mutex mutex = new Mutex(false, "SINGILE_INSTANCE_MUTEX", out flag);
            if (flag)
            {
                Application.Run(new Form1());
            }
            else
            {
                MessageBox.Show("程序已经启动，不能重复运行！", "提示");
                Application.Exit();
            }
        }
    }
}

