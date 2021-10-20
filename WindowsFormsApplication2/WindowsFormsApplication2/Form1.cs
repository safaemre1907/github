using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office;
using Word = Microsoft.Office.Interop.Word;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {

        

        int iTotalFields = 0;


        public Form1()
        {

            

            
InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Object oMissing = System.Reflection.Missing.Value;

            Object oTrue = true;
            Object oFalse = false;

            Word.Application oWord = new Word.Application();
            Word.Document oWordDoc = new Word.Document();


            oWord.Visible = true;

            Object oTemplatePath = System.Windows.Forms.Application.StartupPath + "\\Report.dot";

            oWordDoc = oWord.Documents.Add(ref oTemplatePath, ref oMissing, ref oMissing, ref oMissing);

            foreach (Word.Field myMergeField in oWordDoc.Fields)
            {

                iTotalFields++;
                Word.Range rngFieldCode = myMergeField.Code;
                String fieldText = rngFieldCode.Text;

                if (fieldText.StartsWith(" MERGEFIELD"))
                {

                    Int32 endMerge = fieldText.IndexOf("\\");
                    Int32 fieldNameLength = fieldText.Length - endMerge;
                    String fieldName = fieldText.Substring(11, endMerge - 11);

                    fieldName = fieldName.Trim();


                    if (fieldName == "Birim")
                    {
                        myMergeField.Select();
                        oWord.Selection.TypeText(comboBox2.Text);
                    }


                    if (fieldName == "Marka")
                    {
                        myMergeField.Select();
                        oWord.Selection.TypeText(comboBox1.Text);
                    }

                    if (fieldName == "Model")
                    {
                        myMergeField.Select();
                        oWord.Selection.TypeText(txt_address.Text);
                    }

                  

                    if (fieldName == "SeriNo")
                    {
                        myMergeField.Select();
                        oWord.Selection.TypeText(txt_company.Text);
                    }

                    

                    if (fieldName == "DemirBaşNo")
                    {
                        myMergeField.Select();
                        oWord.Selection.TypeText(txt_odetails.Text);
                    }

                    if (fieldName == "Tarih")
                    {
                        myMergeField.Select();
                        oWord.Selection.TypeText(dateTimePicker1.Text);
                    }


                }
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_odetails_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {

        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;
        }
    }

        
    }

