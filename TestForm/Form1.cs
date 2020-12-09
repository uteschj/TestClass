using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ThreadedTestButton_Click(object sender, EventArgs e)
        {
            RunThreadedTest();
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            RunTest();
        }

        private void TaskTestButton_Click(object sender, EventArgs e)
        {
            RunTaskTest();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CreateHistorFiles();
        }
        private void RunThreadedTest()
        {

            Thread Thread1 = new System.Threading.Thread(delegate () {
                //Your code here
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                TestClass.Class1 class1 = new TestClass.Class1();
                var returnstring = class1.ReadHistory("trs1.h10");
                class1 = null;
                stopWatch.Stop();
                MessageBox.Show("Thread1 " + stopWatch.Elapsed);
                stopWatch = null;
            });
            Thread1.Start();


            Thread Thread2 = new System.Threading.Thread(delegate () {
                //Your code here
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                TestClass.Class1 class1 = new TestClass.Class1();
                var returnstring = class1.ReadHistory("trs2.h10");
                class1 = null;
                stopWatch.Stop();
                MessageBox.Show("Thread2 " + stopWatch.Elapsed);
                stopWatch = null;
            });
            Thread2.Start();

            Thread2.Join();
        }

        private void RunTaskTest()
        {
            Task t1 = Task.Factory.StartNew(() =>
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                TestClass.Class1 class1 = new TestClass.Class1();
                var returnstring = class1.ReadHistory("trs1.h10");
                class1 = null;
                stopWatch.Stop();
                MessageBox.Show("Task1 " + stopWatch.Elapsed);
            });

            Task t2 = Task.Factory.StartNew(() =>
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                TestClass.Class1 class2 = new TestClass.Class1();
                var returnstring = class2.ReadHistory("trs2.h10");
                class2 = null;
                stopWatch.Stop();
                MessageBox.Show("Task2 " + stopWatch.Elapsed);
            });
        }

        private void RunTest()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            TestClass.Class1 class1 = new TestClass.Class1();
            var returnstring = class1.ReadHistory("trs1.h10");
            class1 = null;
            stopWatch.Stop();
            MessageBox.Show("Test " + stopWatch.Elapsed);
            stopWatch = null;
        }

        private void DuplicateHistoryFile()
        {
            if (!File.Exists("trs2.h10"))
            {
                File.Copy("trs1.h10", "trs2.h10");
            }
        }

        private void CreateHistorFiles()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            TestClass.Class1 class1 = new TestClass.Class1();
            class1.CreateHistory("trs1.h10");
            class1 = null;
            stopWatch.Stop();
            MessageBox.Show("Created History File in " + stopWatch.Elapsed);
            DuplicateHistoryFile();

        }

        


    }
}
