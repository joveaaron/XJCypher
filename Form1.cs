using System;
using System.Security.Authentication;
using System.Text.RegularExpressions;

namespace XJCypher
{
    public partial class Form1 : Form
    {
        string[] vela_digitos_orden = ["314", "159", "265", "358", "979", "323", "846", "264", "338", "327", "950", "288", "419", "716", "939", "937", "510", "582", "097", "494", "459", "230", "781", "640", "628", "620", "899"];
        string[] biher_digitos_orden = ["2", "3", "5", "7", "11", "13", "17", "19", "23", "29", "31", "37", "41", "43", "47", "53", "59", "61", "67", "71", "73", "79", "83", "89", "97", "101", "103"];
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tipo_cb.SelectedIndex != -1)
            {
                convertir_btn.Enabled = true;
            }
            else
            {
                convertir_btn.Enabled = false;
            }
        }

        private void convertir_btn_Click(object sender, EventArgs e)
        {
            resultado_tb.Clear();
            string input = input_tb.Text.ToUpper();
            switch (tipo_cb.SelectedIndex)
            {
                case 0: //cifrar en vela
                    foreach (char c in input)
                    {
                        int _a = (byte)c - (byte)'A';
                        if (_a >= 0 && _a < 26)
                        {
                            resultado_tb.Text += vela_digitos_orden[_a];
                            if (separador_chb.Checked)
                            {
                                resultado_tb.Text += "-";
                            }
                        }
                        else
                        {
                            resultado_tb.Text += c;
                        }
                    }
                    break;
                case 1: //cifrar en biher
                    foreach (char c in input)
                    {
                        int _a = (byte)c - (byte)'A';
                        if (_a >= 0 && _a < 26)
                        {
                            resultado_tb.Text += biher_digitos_orden[_a];
                            resultado_tb.Text += "-";
                        }
                        else
                        {
                            resultado_tb.Text += c;
                        }
                    }
                    break;
                case 2: //descifrar vela
                    int position = 0;
                    Regex numregex = new Regex(@"[0-9]");
                    while (true)
                    {
                        if (position >= input.Length)
                        {
                            break;
                        }
                        if (position + 2 < input.Length && numregex.IsMatch(input[position].ToString()) && numregex.IsMatch(input[position + 1].ToString()) && numregex.IsMatch(input[position + 2].ToString())) //check if three characters are numbers
                        {
                            string num = input[position].ToString() + input[position + 1].ToString() + input[position + 2].ToString();
                            for (int i = 0; i < vela_digitos_orden.Length; i++)
                            {
                                if (vela_digitos_orden[i] == num)
                                {
                                    resultado_tb.Text += (char)((byte)'A' + (byte)i);
                                    break;
                                }
                            }
                            position += 3;
                        }
                        else
                        {
                            if(input[position] != '-')
                            {
                                resultado_tb.Text += input[position];
                            }
                            position++;
                        }
                    }
                    break;
                case 3: //descifrar biher
                    int pos = 0;
                    Regex numrgx = new Regex(@"[0-9]");
                    while (true)
                    {
                        if (pos >= input.Length)
                        {
                            break;
                        }
                        int i = 0;
                        for(i = 0; numrgx.IsMatch(input[pos+i].ToString()); i++) //avanzar hasta el siguiente carácter que no sea un número
                        {
                            if(pos+i+1 == input.Length)
                            {
                                i++;
                                break;
                            }
                        }
                        string num2 = input.Substring(pos, i);
                        for (int j = 0; j < biher_digitos_orden.Length; j++)
                        {
                            if (biher_digitos_orden[j] == num2)
                            {
                                resultado_tb.Text += (char)((byte)'A' + (byte)j);
                                break;
                            }
                        }

                        if(pos + i + 1 < input.Length)
                        {
                            if (input[pos + i] != '-')
                            {
                                resultado_tb.Text += input[pos + i];
                            }
                        }
                        
                        pos += i + 1;
                        
                        //resultado_tb.Text += i.ToString();
                        //break;
                    }
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
