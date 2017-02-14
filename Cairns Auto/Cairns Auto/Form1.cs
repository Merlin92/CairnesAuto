/* Student Name: Merlin Bierekofen
 * Student ID: 14101805
 * Date: 31.10.2016
 * Assignment: 4
 
   Cairn’s Automotive performs the following routine maintenance services:
        • Oil change—€26.00
        • Lube job—€18.00
        • Radiator flush—€30.00
        • Transmission flush—€80.00
        • Inspection—€15.00
        • Muffler replacement—€100.00
        • Tyre rotation—€20.00
Cairns also performs other non-routine services and charges for parts and labour (€20 per hour).

Create an application that will:

1) Create a form that resembles the one shown on page 1.
2) Display the total for a customer’s visit to Cairns.
3) Store all the summary information that was generated when the “Calculate” button was
   pressed, in a file called “all_receipts.txt”.
4) The file “all_receipts.txt” should record the current summery information and retain
   summery information from earlier transactions.
5) Display all the summary details stored in “all_receipts.txt” when the “Receipts” button is
   pressed. (You decide how/where this information will be displayed)
6) Handle unexpected errors. (Invalid inputs, file not found etc.)
7) Follow good programming conventions for object names: include comments for some
   methods and at the top of the file to explain what the application is about.
8) Give the form a name that will display at the top of the form.
9) Include code to help the user to identify invalid inputs errors.
10) Use currency formatting to display the results in euros.
11) Include your name in the bottom right corner “Programmed by …………….”
12) Include screenshots showing the application in use.
13) Include screenshots showing the application recovering from invalid input errors.

The application should have the following value-returning methods:

        • OilLubeCharges —Returns the total charges for an oil change and/or a lube job, if any.
        • FlushCharges —Returns the total charges for a radiator flush and/or a transmission flush, if
          any.
        • MiscCharges —Returns the total charges for an inspection, muffler replacement, and/or a
          tyre rotation, if any.
        • OtherCharges —Returns the total charges for other services (parts and labour), if any.
        • TaxCharges —Returns the amount of sales tax, if any. Sales tax is 23% and is charged only
          on parts. If the customer purchases services only, no sales tax is charged.
        • TotalCharges —Returns the total charges

The application should have the following void methods, called when the user clicks the Clear
button:

        • ClearOilLube —Clears the check boxes for oil change and lube job.
        • ClearFlushes —Clears the check boxes for radiator flush and transmission flush.
        • ClearMisc —Clears the check boxes for inspection, muffler replacement, and tyre rotation.
        • ClearOther —Clears the text boxes for parts and labour.
        • ClearFees —Clears the labels that display the labels in the section marked Summary
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Cairns_Auto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        //clears the check boxes for oil change and lube job 
        private void ClearOilLube()
        {
            oilChangeCheckBox.Checked = false;
            lubeJobCheckBox.Checked = false;
        }

        //clears the check boxes for radiator flush and transmission flush.
        private void ClearFlushes()
        {
            transmissionFlushCheckBox.Checked = false;
            radiatorFlushCheckBox.Checked = false;
        }

        //clears the check boxes for inspection, muffler replacement, and tyre rotation.
        private void ClearMisc()
        {
            inspectionCheckBox.Checked = false;
            replaceMufflerCheckBox.Checked = false;
            tyreRotationCheckBox.Checked = false;
        }

        //clears the text boxes for parts and labour.
        private void ClearOther()
        {
            partsTextBox.Text = "";
            labourTextBox.Text = "";
        }

        //clears the labels that are displayed in the section marked Summary
        private void ClearFees()
        {
            serviceAndLabourOutputLabel.Text = "";
            partsOutputLabel.Text = "";
            taxOutputLabel.Text = "";
            totalOutputLabel.Text = "";
        }
        //this method will clear the checkboxes as well as the textboxes and outputlabels 
        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearOilLube();
            ClearFlushes();
            ClearMisc();
            ClearOther();
            ClearFees();
        }
        //this method will calculate the amounts which will be displayed in the summary groupbox
        private void calcButton_Click(object sender, EventArgs e)
        {
            //declare variables for parts and labour
            decimal parts;
            decimal labour;

            //handling errors parts 
            if (decimal.TryParse(partsTextBox.Text, out parts))

                parts = decimal.Parse(partsTextBox.Text);
            else
            {
                MessageBox.Show("Please make sure, that you entered a valid value for the parts charges");
            }

            //handling errors for labour
            if (decimal.TryParse(labourTextBox.Text, out labour))

                labour = decimal.Parse(labourTextBox.Text);
            else
            {
                MessageBox.Show("Please make sure, that you entered a valid value for the labour charges");
            }
            //display fee summary 
            decimal serviceAndLabour = OilLubeCharges() + FlushCharges() + MiscCharges() + labour;
            decimal tax = TaxCharges();
            decimal total = TotalCharges(serviceAndLabour, parts, tax);

            //decimal to string conversion 
            serviceAndLabourOutputLabel.Text = serviceAndLabour.ToString("c");
            partsOutputLabel.Text = parts.ToString("c");
            taxOutputLabel.Text = tax.ToString("c");
            totalOutputLabel.Text = total.ToString("c");
        }
        //method for calculating oil and lube charges 
        private decimal OilLubeCharges()
        {
            const decimal Oil_Change = 26m;
            const decimal Lube_Job = 18m;
            decimal sum = 0m;

            if (oilChangeCheckBox.Checked)
            {
                sum += Oil_Change;
            }

            if (lubeJobCheckBox.Checked)
            {
                sum += Lube_Job;
            }

            return sum;
        }

        //method for calculating flush charges
        private decimal FlushCharges()
        {
            const decimal Radiator_Flush = 30m;
            const decimal Transmission_Flush = 80m;
            decimal sum = 0m;

            if (radiatorFlushCheckBox.Checked)
            {
                sum += Radiator_Flush;
            }

            if (transmissionFlushCheckBox.Checked)
            {
                sum += Transmission_Flush;
            }

            return sum;
        }

        //method for calculating misc charges
        private decimal MiscCharges()
        {
            const decimal Inspection = 15m;
            const decimal Muffler_Replacement = 100m;
            const decimal Tyre_Rotation = 20m;
            decimal sum = 0m;

            if (inspectionCheckBox.Checked)
            {
                sum += Inspection;
            }

            if (replaceMufflerCheckBox.Checked)
            {
                sum += Muffler_Replacement;
            }

            if (tyreRotationCheckBox.Checked)
            {
                sum += Tyre_Rotation;
            }

            return sum;
        }

        //method for calculating other charges
        private decimal OtherCharges()
        {
            decimal sum = 0m;
            sum += decimal.Parse(partsTextBox.Text);
            sum += decimal.Parse(labourTextBox.Text);
            return sum;
        }

        //method for calculating tax charges
        private decimal TaxCharges()
        {
            const decimal tax = 0.23m;
            decimal sum;
            sum = tax * (decimal.Parse(partsTextBox.Text));
            return sum;
        }

        //method for calculating the full charges 
        private decimal TotalCharges(decimal value1, decimal value2, decimal value3)
        {
            decimal sum = value1 + value2 + value3;
            return sum;
        }

        private void receiptsButton_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\Users\Merlz\Dropbox\Uni\Courses\Business Applications Programming\Assignments\Assign_4\Receipt.txt";
                StreamWriter outputFile = new StreamWriter(path, true);

                outputFile.WriteLine("Service & Labour: " + serviceAndLabourOutputLabel.Text);
                outputFile.WriteLine("Parts: " + partsOutputLabel.Text);
                outputFile.WriteLine("Tax (on parts): " + taxOutputLabel.Text);
                outputFile.WriteLine("Total Fees: " + totalOutputLabel.Text);
                outputFile.WriteLine("");
                outputFile.Close();

                MessageBox.Show("Receipt generated");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //this method will close the program
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
