using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookApplication.HW2_additions;
using FacebookApplication.UI;
using FacebookApplication.UI.blastFromThePast;
using FacebookWrapper.ObjectModel;

namespace FacebookApplication.BlastFromThePast
{
    static class BlastFromThePastManager
    {
        internal static void InitiateBlastFromThePast(User i_LoggedInUser,FBPageWrapperForm i_PageToPresentOn)
        {
            PastYearSelectionForm yearSelectionForm = new PastYearSelectionForm();

            if(yearSelectionForm.ShowDialog() == DialogResult.OK)
            {
                Photo randomPastPhoto = RandomPastPhotoGenerator.GenerateRandomPhotoFromGivenYear(
                    i_LoggedInUser,
                    yearSelectionForm.CurrentlyChosenYear);
                PastPhotoForm photoForm = new PastPhotoForm(randomPastPhoto);
                photoForm.ShowDialog();
            }
        }
    }
}
