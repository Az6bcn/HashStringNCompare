using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace HashStringNCompare
{
    public partial class Form1 : Form
    {
        private string hashed_result;
        private string hashed_result2;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnToHash_Click(object sender, EventArgs e)
        {
            //get the input string to be Hashed
            string txtToHash = textStringToHash.Text;
            //Hash this data 
            HashClass H = new HashClass();
            hashed_result = H.MD5_Encode(txtToHash);
            //show the result in the form
            textResultHash.Text = hashed_result;


        }

        private void btnCompareToHash_Click(object sender, EventArgs e)
        {
            //get the input string to be Hashed
            string txtToHash = textStringToHash.Text;
            //Hash this data 
            HashClass H = new HashClass();
            hashed_result = H.MD5_Encode(txtToHash);
            //get the input string to be Hashed
            string txtToHash2 = textHashCompare.Text;
            hashed_result2 = H.MD5_Encode(txtToHash2);

            //Compare result
            bool res = this.hashed_result.Equals(this.hashed_result2);
            if (res)
            {
                MessageBox.Show("Son Iguales !!! " + this.hashed_result + "==" + this.hashed_result2);
            }
            else MessageBox.Show("No Son Iguales!!!!");
        }
    }
    public class HashClass
    {
        //method to Hash--> returns a string which is the Hash itself
        public string MD5_Encode (string stringToHash)
        {
            //MD5 Object
            MD5 md5Hash = MD5.Create();
            //Convert the input string into a Byte Array and compute the HASH
            byte[] hash = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(stringToHash));

            //Convert the Hashed Byte Array to string using StringBuilder
            StringBuilder sBuilder = new StringBuilder();

            //Iterate the Array of Hashed String and convert them to Hex string 
            for(int i= 0; i < hash.Length; i++)
            {
                sBuilder.Append(hash[i].ToString("X2"));
            }

            //return the Hex string
            return sBuilder.ToString();
        }
    }
    }
