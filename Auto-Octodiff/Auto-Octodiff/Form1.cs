using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Octodiff;
using Octodiff.Core;
using Octodiff.Diagnostics;

namespace Auto_Octodiff
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Show the dialog that allows user to select a file, the 
            // call will result a value from the DialogResult enum
            // when the dialog is dismissed.
            DialogResult result = openFileDialog1.ShowDialog();
            // if a file is selected
            if (result == DialogResult.OK)
            {
                // Set the selected file URL to the textbox
                this.textBox1.Text = this.openFileDialog1.FileName;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Apply delta file to create new file
                var patcherPath = System.AppDomain.CurrentDomain.BaseDirectory;

                var exePath = Path.GetDirectoryName(textBox1.Text); // get the folder of Roguelands.exe
                var assemblyDirectory = Path.Combine(exePath, @"Roguelands_Data\Managed");
                if (!Directory.Exists(assemblyDirectory))
                {
                    textBox2.AppendText("Unable to find directory: " + assemblyDirectory);
                    return;
                }
                var assemblyPath = Path.Combine(assemblyDirectory, "Assembly-CSharp.dll");
                if (!File.Exists(assemblyPath))
                { 
                    textBox2.AppendText("Unable to find file: " + assemblyPath);
                    return;
                }
                var cleanPath = Path.Combine(assemblyDirectory, "Original_Assembly-CSharp.dll");
                if (File.Exists(cleanPath))
                    textBox2.AppendText("Warning: Original_Assembly-CSharp.dll already exists. This indicates the assembly may have already been patched. A new Original_Assembly-CSharp.dll will not be created, and the Assembly-CSharp.dll will be replaced with a patched version of the Original_Assembly-CSharp.dll\r\n");
                else
                    File.Copy(assemblyPath, cleanPath, true);

                var deltaApplier = new DeltaApplier { SkipHashCheck = false };
                using (var basisStream = new FileStream(cleanPath, FileMode.Open, FileAccess.Read, FileShare.Read))
                using (var deltaStream = new FileStream(Path.Combine(patcherPath, "patch"), FileMode.Open, FileAccess.Read, FileShare.Read))
                using (var newFileStream = new FileStream(assemblyPath, FileMode.Create, FileAccess.ReadWrite, FileShare.Read))
                {
                    deltaApplier.Apply(basisStream, new BinaryDeltaReader(deltaStream, new ConsoleProgressReporter()), newFileStream);
                    textBox2.AppendText("Successfully patched.\r\n");
                }
            }
            catch(Exception err)
            {
                textBox2.AppendText(err.Message + "\r\n");
            }
            

            //"octodiff patch vanillaFile modDelta.octodelta newFile --progress"
        }
    }
}
