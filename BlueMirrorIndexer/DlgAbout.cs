using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;

namespace BlueMirrorIndexer
{
    public partial class DlgAbout : BaseDialogs.FormDialogList
    {
        
        public DlgAbout() {
            InitializeComponent();
            llCopyright.Text = assemblyCopyright;
            llVersion.Text = String.Format(llVersion.Text, assemblyVersion);
            llTitle.Text = ProductName;
        }

        private void linkLabel1_Click(object sender, EventArgs e) {
            Process navigate = new Process();
            navigate.StartInfo.FileName = "mailto:kowaliszyn@users.sourceforge.net";
            navigate.Start();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process navigate = new Process();
            navigate.StartInfo.FileName = "http://sourceforge.net/projects/octoindex/";
            navigate.Start();
        }

        private string assemblyCopyright {
            get {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                    return "";
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        private string assemblyVersion {
            get {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        //private string assemblyTitle {
        //    get {
        //        object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
        //        if (attributes.Length == 0)
        //            return "";
        //        return ((AssemblyTitleAttribute)attributes[0]).Title;
        //    }
        //}

        private void llCodePlex_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process navigate = new Process();
            navigate.StartInfo.FileName = "http://www.codeplex.com/octopi";
            navigate.Start();
        }

    }
}

