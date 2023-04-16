using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        
        public CreateTeamForm()
        {
            InitializeComponent();

            //CreateSampleData();

            WireUpList();
        }
        
        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Alex", LastName = "Gross" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Max", LastName = "Mustermann" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Peter", LastName = "Hansen" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Alina", LastName = "Heinrich" });

        }

        public void WireUpList()
        {
            selectTeamDropDown.DataSource = null;

            selectTeamDropDown.DataSource = availableTeamMembers;
            selectTeamDropDown.DisplayMember = "FullName";

            teamMemberListbox.DataSource = null;

            teamMemberListbox.DataSource = selectedTeamMembers;
            teamMemberListbox.DisplayMember = "FullName";
        }
        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();

                p.FirstName = firstNameValue.Text;
                p.LastName = lastNameValue.Text;
                p.EmailAddress = emailValue.Text;
                p.CellphoneNumber = cellphoneValue.Text;

                p = GlobalConfig.Connection.CreatePerson(p);

                selectedTeamMembers.Add(p);

                WireUpList();

                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                cellphoneValue.Text = "";
            }
            else
            {
                MessageBox.Show("You need to fill in all of the fields.");
            }
        }
        
        private bool ValidateForm()
        {
            if (firstNameValue.Text.Length == 0)
            {
                return false;
            }
            if (lastNameValue.Text.Length == 0)
            {
                return false;
            }
            if (emailValue.Text.Length == 0)
            {
                return false;
            }
            if (cellphoneValue.Text.Length == 0)
            {
                return false;
            }

            return true;
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamDropDown.SelectedItem;

            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                WireUpList(); 
            }
            
        }

        private void deleteSelectedMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMemberListbox.SelectedItem;

            if (p != null)
            { 
               selectedTeamMembers.Remove(p);
               availableTeamMembers.Add(p);

               WireUpList();
            }
        }
    }
}
