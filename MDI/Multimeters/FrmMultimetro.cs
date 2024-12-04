using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Devices.Visa.Multimeters;
using Devices.Visa.PowerSupplies;
}

namespace Instrumentation
{
    public partial class FormMultimetro : Form
    {
        private bool Measure;

        Agilent34401A agilent34401a = new Agilent34401A
        {
            DeviceAddress = "GPIB0::22::INSTR"
        };

        public FormMultimetro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //Multimeter();
            agilent34401a.Initialization();

            agilent34401a.MeasureEvent += Agilent34401a_MeasureEvent;


        }

        private void Agilent34401a_MeasureEvent(object sender, string measure, string unit)
        {
            LbMode.Text = $@"{measure} {unit}"; 
        }

        private void btn_Click(object sender, EventArgs e)
        {


            var measureType = (Button)sender;

            switch (measureType.Tag)
            {
                case "DC V":
                    agilent34401a.GetMeasure(Agilent34401A.MeasureType.VoltDc);
                    break;
                case "AC V":
                    agilent34401a.GetMeasure(Agilent34401A.MeasureType.VoltAc);
                    break;
                case "DC I":
                    agilent34401a.GetMeasure(Agilent34401A.MeasureType.CurDc);
                    break;
                case "AC I":
                    agilent34401a.GetMeasure(Agilent34401A.MeasureType.CurAc);
                    break; ;
                case "Resistor":
                    agilent34401a.GetMeasure(Agilent34401A.MeasureType.Resistance);
                    break;
                case "Diode":
                    agilent34401a.GetMeasure(Agilent34401A.MeasureType.Diode);
                    break;
                case "Freq":
                    agilent34401a.GetMeasure(Agilent34401A.MeasureType.Freq);
                    break;
                case "Cont":
                    agilent34401a.GetMeasure(Agilent34401A.MeasureType.Cont);
                    break;
                default:
                    LbMode.Text = "SELECT MODE";
                    LblDisplay.Text = "-  - - - - - - - - - - - - - - - ";
                    break;
            }

           } 
        }
        //private void Multimeter()
        //{
        //    Measure = true;

        //    Task.Run(() =>
        //    {
        //        var agilent34401a = new Agilent34401A
        //        {
        //            DeviceAddress = "GPIB0::22::INSTR"
        //        };

        //        agilent34401a.MeasVoltageEvent += Agilent34401A_MeasVoltageEvent;
        //        agilent34401a.Initialization();
        //        agilent34401a.FindDevice();
        //        agilent34401a.SetVoltagetDc();

        //        while (Measure)
        //        {
        //            var voltage = agilent34401a.m();


        //            this.Invoke((MethodInvoker)delegate
        //            {
        //                txtVoltage.Text = voltage.ToString();
        //            });

        //            Thread.Sleep(1000);
        //        }
        //    });


        
}
