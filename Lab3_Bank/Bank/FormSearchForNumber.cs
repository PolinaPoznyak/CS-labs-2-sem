﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Bank
{
    public partial class FormSearchForNumber : Form
    {
        public FormSearchForNumber()
        {
            InitializeComponent();
        }

        List<Owner> owners;
        private const string path = @"SearchNum.json";
        public FormSearchForNumber(List<Owner> owners)
        {     
            InitializeComponent();
            this.owners = owners;
        }
        private void numberSearch_button_Click(object sender, EventArgs e)
        {
            List<Owner> searchedOwners = new List<Owner>();
            var search = owners.FindAll(item => item.Account.Number.Contains(numberSearchTextBox.Text));
            if (search.Count() > 0)
            {
                searchedOwners.Clear();
                foreach (var owner in search)
                {
                    OutputBox.Text += owner.ShowOwnerInfo();
                    searchedOwners.Add(owner);
                }
            }
            var jsonData = JsonConvert.SerializeObject(owners);

            using (var streamWriter = new StreamWriter(path))
            {
                streamWriter.Write(jsonData);
            }
        }
    }
}
