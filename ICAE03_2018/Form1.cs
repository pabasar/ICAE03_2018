using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICAE03_2018
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        string gender = "";

        CheckBox[] languageAbility = new CheckBox[3];

        private void rdoMale_CheckChanged(object sender, EventArgs e)
        {
            gender = rdoMale.Text; 
        }

        private void rdoFemale_CheckChanged(object sender, EventArgs e)
        {
            gender = rdoFemale.Text;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            languageAbility[0] = chkRead;
            languageAbility[1] = chkWrite;
            languageAbility[2] = chkSpeak;

            cmbStream.Items.Add("Arts");
            cmbStream.Items.Add("Maths");
            cmbStream.Items.Add("Biology");
            cmbStream.Items.Add("Technology");
            cmbStream.Items.Add("Commerce");
            cmbStream.Sorted = true;

            rdoMale.Checked = true;  
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string msg = "";
            txtDisplay.Text = "";
            string language = "";
            string subjects = "";

            for (int i = 0; i < 3; i++)
            {
                if (languageAbility[i].Checked)
                {
                    language += "\r\n" + languageAbility[i].Text + ":Can " + languageAbility[i].Text;
                }
                else
                {
                    language += "\r\n" + languageAbility[i].Text + ":Can't " + languageAbility[i].Text;
                }
            }

            for(int i=0;i<lstFollow.Items.Count;i++)
            {
                subjects += "\r\n"+lstFollow.Items[i].ToString();
            }

            msg += "\r\n ******* Personal Details *******";
            msg += "\r\nName: " + txtName.Text;
            msg += "\r\nRegistration Number: " + txtReg.Text;
            msg += "\r\nSex: " + gender;
            msg += "\r\nAddress: " + txtAddress.Text;

            msg += "\r\n ******* Language Ability in English *******";
            msg += language;

            msg += "\r\n ******* Educational Details *******";
            msg += "\r\nStream: " + cmbStream.Text;
            msg += "\r\nSubjects Followed: " + subjects;

            txtDisplay.Text = msg;
        }

        private void cmbStream_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstOffer.Items.Clear();
            lstFollow.Items.Clear();
            if (cmbStream.Text == "Arts")
            {   
                lstOffer.Items.Add("Music");
                lstOffer.Items.Add("Drama");
                lstOffer.Items.Add("Dance");
            }
            else if (cmbStream.Text == "Maths")
            {
                lstOffer.Items.Add("Combined Maths");
                lstOffer.Items.Add("Chemistry");
                lstOffer.Items.Add("Physics");
            }
            else if (cmbStream.Text == "Biology")
            {
                lstOffer.Items.Add("Biology");
                lstOffer.Items.Add("Chemistry");
                lstOffer.Items.Add("Physics");
            }
            else if (cmbStream.Text == "Commerce")
            {
                lstOffer.Items.Add("Business Studies");
                lstOffer.Items.Add("Accounting");
                lstOffer.Items.Add("Management");
            }
            else if (cmbStream.Text == "Technology")
            {
                lstOffer.Items.Add("Engineering Technology");
                lstOffer.Items.Add("Science for Technology");
                lstOffer.Items.Add("Biosystems Technology");
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            while (lstOffer.SelectedItems.Count != 0)
            {
                lstFollow.Items.Add(lstOffer.Items[lstOffer.SelectedIndices[0]]);
                lstOffer.Items.RemoveAt(lstOffer.SelectedIndices[0]);
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            while (lstFollow.SelectedItems.Count != 0)
            {
                lstOffer.Items.Add(lstFollow.Items[lstFollow.SelectedIndices[0]]);
                lstFollow.Items.RemoveAt(lstFollow.SelectedIndices[0]);
            }
        }

        private void btnRightAll_Click(object sender, EventArgs e)
        {
            for(int i=0;i<lstOffer.Items.Count;i++)
            {
                lstFollow.Items.Add(lstOffer.Items[i]);
            }
            lstOffer.Items.Clear();
        }

        private void btnLeftAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstFollow.Items.Count; i++)
            {
                lstOffer.Items.Add(lstFollow.Items[i]);
            }
            lstFollow.Items.Clear();
        }
    }
}
