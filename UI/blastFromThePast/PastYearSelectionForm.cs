using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacebookApplication.UI
{
    internal partial class PastYearSelectionForm : Form
    {
        private static readonly int sr_InitialYear;
        internal int CurrentlyChosenYear { get; private set; }

        static PastYearSelectionForm()
        {
            sr_InitialYear = DateTime.Now.Year;
        }

        internal PastYearSelectionForm()
        {
            InitializeComponent();
            this.CurrentlyChosenYear = sr_InitialYear;
            this.plusButton.Enabled = false;
            updateChoseYearBox();
            initializeEventHandling();
        }

        private void initializeEventHandling()
        {
            this.plusButton.MouseClick += plusButton_MouseClick;
            this.minusButton.MouseClick += minusButton_MouseClick;
        }
        private void minusButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.CurrentlyChosenYear--;
            updateChoseYearBox();
            this.plusButton.Enabled = true;
        }

        private void plusButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.CurrentlyChosenYear++;
            if (this.CurrentlyChosenYear == sr_InitialYear)
            {
                this.plusButton.Enabled = false;
            }

            updateChoseYearBox();
        }

        private void updateChoseYearBox()
        {
            this.chosenYearBox.Text = this.CurrentlyChosenYear.ToString();
        }
    }
}