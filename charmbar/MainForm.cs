/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 6/16/2020
 * Time: 1:29 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace charmbar
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MainFormMouseHover(object sender, EventArgs e)
		{
			while(Left>Screen.PrimaryScreen.WorkingArea.Width-140){
				Left-=30;
				Thread.Sleep(50);
			}
		}
		void MainFormMouseLeave(object sender, EventArgs e)
		{
			while(Left<Screen.PrimaryScreen.WorkingArea.Width-4){
				Left+=30;
				Thread.Sleep(50);
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{

		}
	}
}
