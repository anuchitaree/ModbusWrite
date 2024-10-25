using EasyModbus;
using ModbusWrite.Models;
using ModbusWrite.Modules;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ModbusWrite
{
    public partial class Form1 : Form
    {

        ModbusServer modbusServer;
        byte unitIdentify = 1;
        List<WriteModel> drafmodel = new List<WriteModel>();

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
            for (int i = 0; i < 31; i++)
            {
                cmbUnitIdentify.Items.Add(i + 1);
            }
            cmbUnitIdentify.SelectedIndex = 0;
            RegisterAddress();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "START")
            {
                modbusServer = new ModbusServer();
                modbusServer.Listen();
                labStatus.Text = "Status : Started";
                btnStart.Text = "STOP";
                btnStart.BackColor = Color.GreenYellow;
                btnSetVal.Visible = true;
            }
            else
            {
                modbusServer.StopListening();
                modbusServer = null;
                labStatus.Text = "Status :";
                btnStart.BackColor = SystemColors.Control;
                btnStart.Text = "START";
                btnSetVal.Visible = false;
            }
        }

        private void btnSetVal_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "START") return;
            try
            {
                modbusServer.UnitIdentifier = byte.Parse(cmbUnitIdentify.Text);
                int iaddress = int.Parse(textRegAdr.Text);
                if(iaddress <=   0) return;

                if (cmbRegType.SelectedIndex == 3)
                {
                    ModbusServer.HoldingRegisters regs = modbusServer.holdingRegisters;
                    (short, short) output = ModbusOps.UInt32ToShort(textReqVal.Text);
                    regs[iaddress] = output.Item1;
                    regs[iaddress + 1] = output.Item2;

                    var itemIndex = drafmodel.FindIndex(x => x.RegType == 3 && x.RegAddr == 400000 + iaddress-1);
                    var item = drafmodel.ElementAt(itemIndex);
                    item.DecValue = output.Item1;
                    item.HexValue = Convertion.Dec2Hex(output.Item1);


                    var itemIndex1 = drafmodel.FindIndex(x => x.RegType == 3 && x.RegAddr == 400000 + iaddress );
                    var item1 = drafmodel.ElementAt(itemIndex1);
                    item1.DecValue = output.Item2;
                    item1.Int32Value = int.Parse(textReqVal.Text);
                    item1.HexValue = Convertion.Dec2Hex(output.Item2);


                }
                else if (cmbRegType.SelectedIndex == 2)
                {
                    ModbusServer.InputRegisters regs = modbusServer.inputRegisters;
                    (short, short) output = ModbusOps.UInt32ToShort(textReqVal.Text);
                    regs[iaddress] = output.Item1;
                    regs[iaddress + 1] = output.Item2;

                    var itemIndex = drafmodel.FindIndex(x => x.RegType == 2 && x.RegAddr == 300000 + iaddress-1);
                    var item = drafmodel.ElementAt(itemIndex);
                    item.DecValue = output.Item1;
                    item.HexValue = Convertion.Dec2Hex(output.Item1);

                    var itemIndex1 = drafmodel.FindIndex(x => x.RegType == 2 && x.RegAddr == 300000 + iaddress );
                    var item1 = drafmodel.ElementAt(itemIndex1);
                    item1.DecValue = output.Item2;
                    item1.Int32Value = int.Parse(textReqVal.Text);
                    item1.HexValue = Convertion.Dec2Hex(output.Item2);
                }
                else if (cmbRegType.SelectedIndex == 1)
                {
                    bool ival = false;
                    if (int.Parse(textReqVal.Text) > 0 || textReqVal.Text.ToLower() == "true")
                    {
                        ival = true;
                    }
                    ModbusServer.DiscreteInputs regs = modbusServer.discreteInputs;
                    regs[iaddress] = ival;
                    var itemIndex = drafmodel.FindIndex(x => x.RegType == 1 && x.RegAddr == 100000 + iaddress-1);
                    var item1 = drafmodel.ElementAt(itemIndex);
                    item1.DecValue = ival == true ? 1 : 0;
                    item1.DecString = ival == true ? "True" : "False";
                    item1.HexValue = Convertion.Dec2Hex(item1.DecValue);
                    item1.Int32Value = item1.DecValue;

                }
                else if (cmbRegType.SelectedIndex == 0)
                {
                    bool ival = false;
                    if (int.Parse(textReqVal.Text) > 0 || textReqVal.Text.ToLower() == "true")
                    {
                        ival = true;
                    }
                    ModbusServer.Coils regs = modbusServer.coils;
                    regs[iaddress] = ival;
                    var itemIndex = drafmodel.FindIndex(x => x.RegType == 0 && x.RegAddr == iaddress-1);
                    var item1 = drafmodel.ElementAt(itemIndex);
                    item1.DecValue = ival == true ? 1 : 0;
                    item1.DecString = ival == true ? "True" : "False";
                    item1.HexValue = Convertion.Dec2Hex(item1.DecValue);
                    item1.Int32Value = item1.DecValue;
                }
                RegisterTypeSelected();
            }
            catch
            {

            }
        }

       

        private void RegisterTypeSelected()
        {
            var data = drafmodel
                .Where(x => x.RegType == cmbRegType.SelectedIndex)
                .OrderBy(x => x.Id).ToList();
            int r = 0;
            dgv.Rows.Clear();
            foreach (var item in data)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgv);
                row.Cells[0].Value = r;
                row.Cells[1].Value = item.RegAddrString;
                if (cmbRegType.SelectedIndex == 0 || cmbRegType.SelectedIndex == 1)
                {
                    row.Cells[2].Value = item.DecString;
                }
                else
                {

                    row.Cells[2].Value = item.DecValue;
                }
                row.Cells[3].Value = item.HexValue;
                row.Cells[4].Value = item.Int32Value;
                dgv.Rows.Add(row);
                r++;
            }


        }

        private void RegisterAddress()
        {

            int[] regaddr = new int[] { 0, 100000, 300000, 400000 };
            int c = 0;
            for (int r = 0; r < 4; r++)
            {
                for (int i = 0; i < 20; i++)
                {
                    var model = new WriteModel()
                    {
                        Id = c,
                        RegType = r,
                        RegAddrString = (regaddr[r] + i).ToString().PadLeft(6, '0').Insert(3, " "),
                        RegAddr = regaddr[r] + i,
                    };
                    c++;
                    drafmodel.Add(model);
                }
            }
        }


        private void InitDvg()
        {
            this.dgv.ColumnCount = 5;
            this.dgv.Columns[0].Name = "No";
            this.dgv.Columns[0].Width = 30;
            this.dgv.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dgv.Columns[1].Name = "Address";
            this.dgv.Columns[1].Width = 100;
            this.dgv.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgv.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv.Columns[2].Name = "DEC/BOOL";
            this.dgv.Columns[2].Width = 100;
            this.dgv.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dgv.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgv.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv.Columns[3].Name = "HEX";
            this.dgv.Columns[3].Width = 100;
            this.dgv.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dgv.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgv.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv.Columns[4].Name = "Int32";
            this.dgv.Columns[4].Width = 100;
            this.dgv.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dgv.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgv.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

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

            btnSetVal.Visible = false;
        }

        private void cmbRegType_SelectedIndexChanged(object sender, EventArgs e)
        {
            RegisterTypeSelected();
        }

        private void cmbUnitIdentify_SelectedValueChanged(object sender, EventArgs e)
        {
            unitIdentify = byte.Parse(cmbUnitIdentify.Text);
        }
    }
}
