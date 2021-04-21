using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballScoringSystem
{
    public partial class ScoringSystemForm : Form
    {
        //Controls.
        private TextBox txtBox = new TextBox();
        private Button btnAdd = new Button();
        private ListBox lstBox = new ListBox();
        private CheckBox chkBox = new CheckBox();
        private Label homeTeamLabel = new Label();

        private Label homeTeamLabel = new Label();

        public ScoringSystemForm()
        {
            InitializeComponent();
        }

        public CloseButton()
        {
            this.btnAdd.BackColor = Color.Gray;
            this.btnAdd.Text = "Add";
            this.btnAdd.Location = new System.Drawing.Point(90, 25);
            this.btnAdd.Size = new System.Drawing.Size(50, 25);
        }

    }
}
