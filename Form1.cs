using EasyModbus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModbusWrite.Models;

namespace ModbusWrite
{
    public partial class Form1 : Form
    {

        ModbusServer modbusServer;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbRegType.SelectedIndex = 0;
            cmbStep.SelectedIndex = 0;
            cmbQty.SelectedIndex = 0;
            InitDvg();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "START")
            {
                modbusServer = new ModbusServer();
                modbusServer.Listen();
                labStatus.Text = "Status : Started";
                btnStart.Text = "STOP";
            }
            else
            {
                modbusServer.StopListening();
                modbusServer = null;
                labStatus.Text = "Status :";
                btnStart.Text = "START";
            }
        }

        private void btnSetVal_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "START") return;
            try
            {

                int iaddress = int.Parse(textRegAdr.Text);

                if (cmbRegType.SelectedIndex == 2)
                {
                    short ival = short.Parse(textReqVal.Text);
                    ModbusServer.HoldingRegisters regs = modbusServer.holdingRegisters;
                    regs[iaddress] = ival;
                }
                else if (cmbRegType.SelectedIndex == 3)
                {
                    short ival = short.Parse(textReqVal.Text);
                    ModbusServer.InputRegisters regs = modbusServer.inputRegisters;
                    regs[iaddress] = ival;
                }
                else if (cmbRegType.SelectedIndex == 1)
                {
                    bool ival = false;
                    if (textReqVal.Text == "1" || textReqVal.Text.ToLower() == "true")
                    {
                        ival = true;
                    }
                    ModbusServer.DiscreteInputs regs = modbusServer.discreteInputs;
                    regs[iaddress] = ival;
                }
                else if (cmbRegType.SelectedIndex == 0)
                {
                    bool ival = false;
                    if (textReqVal.Text == "1" || textReqVal.Text.ToLower() == "true")
                    {
                        ival = true;
                    }
                    ModbusServer.Coils regs = modbusServer.coils;
                    regs[iaddress] = ival;
                }
            }
            catch
            {

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnDraft_Click(object sender, EventArgs e)
        {
            try
            {
                int regAddr = 0;
                int startAddr = int.Parse(txtStartAddr.Text);
                int step = cmbStep.SelectedIndex == 0 ? 1 : 2;
                int qty = cmbQty.SelectedIndex == 0 ? 10 : 20;

                switch (cmbRegType.SelectedIndex)
                {
                    case 0:
                        regAddr = 400000;
                        break;
                    case 1:
                        regAddr = 300000;
                        break;
                    case 2:
                        regAddr = 200000;
                        break;
                    case 3:
                        regAddr = 000000;
                        break;
                }
                regAddr = regAddr + startAddr;

                var drafmodel = new List<WriteModel>();

                for (int i = 0; i < qty; i++)
                {
                    var model = new WriteModel()
                    {
                        Id = i,
                        Address = (regAddr + i * step).ToString().PadLeft(6, '0').Insert(3, " "),
                    };
                    drafmodel.Add(model);
                }


                dgv.Rows.Clear();
                var r = 0;
                foreach (var item in drafmodel)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgv);
                    row.Cells[0].Value = item.Id;
                    row.Cells[1].Value = item.Address;
                    //row.Cells[2].Value = item.DecValue;


                    //var hexStr = int.Parse(item.DecValue, System.Globalization.NumberStyles.HexNumber).ToString();
                    //row.Cells[3].Value = hexStr.PadLeft(4, '0');


                    //string.Format("{0:x}", item.DecValue);
                    dgv.Rows.Add(row);

                    r++;
                }

                //var lb = new Label() {lb1.Text, lb2.Text, lb3.Text, lb4.Text, lb5.Text };


            }
            catch (Exception)
            {

                throw;
            }

        }

        private void InitDvg()
        {
            this.dgv.ColumnCount = 4;
            this.dgv.Columns[0].Name = "No";
            this.dgv.Columns[0].Width = 30;
            this.dgv.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dgv.Columns[1].Name = "Address";
            this.dgv.Columns[1].Width = 200;
            this.dgv.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dgv.Columns[2].Name = "DEC";
            this.dgv.Columns[2].Width = 200;
            this.dgv.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dgv.Columns[3].Name = "HEX";
            this.dgv.Columns[3].Width = 200;
            this.dgv.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dgv.RowHeadersWidth = 30;
            this.dgv.DefaultCellStyle.Font = new Font("Tahoma", 10);
            this.dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);
            this.dgv.RowHeadersWidth = 4;
            this.dgv.RowTemplate.Height = 30;
            this.dgv.RowsDefaultCellStyle.BackColor = Color.White;
            this.dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.PowderBlue;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToResizeColumns = false;
        }
    }
}
