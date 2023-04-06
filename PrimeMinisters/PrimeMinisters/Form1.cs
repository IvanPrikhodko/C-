using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;


//Ivan Prikhodko 301261209


namespace PrimeMinisters
{
    public partial class frmPrimeMinisters : Form
    {
        private Dictionary<string, PrimeMinister> primeMinisters = new Dictionary<string, PrimeMinister>();
        private string photosFolderPath = "photos/";
        private string defaultPhotoFileName = "trudeau.jpg";



        public frmPrimeMinisters()
        {
            InitializeComponent();
        }

        private void frmPrimeMinisters_Load(object sender, EventArgs e)
        {
            // Load the prime ministers from the JSON file
            string json = File.ReadAllText("primeMinisters.json");
            primeMinisters = JsonConvert.DeserializeObject<Dictionary<string, PrimeMinister>>(json);


            // Populate the list box with the prime ministers' last names
            lstPrimeMinisters.DataSource = new BindingSource(primeMinisters, null);
            lstPrimeMinisters.DisplayMember = "Key";
            lstPrimeMinisters.ValueMember = "Value";

            // Set the first prime minister as the default selection
            lstPrimeMinisters.SelectedIndex = 0;


            lstPrimeMinisters.SelectedIndexChanged += lstPrimeMinisters_SelectedIndexChanged;
            lstPrimeMinisters.SelectedIndex = 1;
            lstPrimeMinisters.SelectedIndex = 0;
        }

        private void lstPrimeMinisters_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            // Get the selected prime minister
            PrimeMinister selectedPM = (PrimeMinister)lstPrimeMinisters.SelectedValue;
            

            // Display the prime minister's details
            lblName.Text = selectedPM.FirstName + " " + selectedPM.LastName;
            lblTerm.Text = selectedPM.Term;
            lblParty.Text = selectedPM.Party;

            // Load the prime minister's photo
            string photoFileName = selectedPM.LastName.ToLower() + ".jpg";
            string photoFilePath = photosFolderPath + photoFileName;
            picPhoto.Load(photoFilePath);
        }
    }
   }

