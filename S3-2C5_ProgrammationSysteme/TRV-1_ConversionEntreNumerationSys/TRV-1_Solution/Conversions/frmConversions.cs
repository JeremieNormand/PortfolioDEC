using System;
using System.Drawing;
using System.Windows.Forms;
using static Conversions.CBase;

namespace Conversions
{
    public partial class frmConversions : Form
    {
        bool _BinaireADecValidite = false;
        bool _DecimalABinValidite = false;
        bool _HexaADecValidite = false;
        bool _DecimalAHexValidite = false;
        bool _BinaireAHexValidite = false;
        bool _HexaABinValidite = false;

        bool ValiderDimensionBin(string binaire)
        {
            return binaire.Length < 9 ? true : false;
        }

        bool ValiderBinaire(string binaire)
        {
            bool validite = int.TryParse(binaire, out int bin);
            if (validite)
            {
                foreach (char chiffre in binaire)
                {
                    if (validite)
                    {
                        if (chiffre != '0' && chiffre != '1')
                        {
                            validite = false;
                        }
                    }
                }
            }
            return validite;
        }

        bool ValiderDimensionDec(string deciml)
        {
            return deciml.Length < 4 ? true : false;
        }

        bool ValiderDecimal(string deciml)
        {
            bool validite = int.TryParse(deciml, out int dec);
            if (validite)
            {
                if (dec >= 0 && dec < 256)
                {
                    validite = true;
                }
            }
            return validite;
        }

        bool ValiderDimensionHex(string hexa)
        {
            return hexa.Length < 3 ? true : false;
        }

        bool ValiderHexa(string hexa)
        {
            bool validite = true;
            foreach (char chiffre in hexa)
            {
                if (validite)
                {
                    if ((int)chiffre < (int)'0' || (int)chiffre > (int)'9')
                    {
                        if ((int)chiffre < (int)'A' || (int)chiffre > (int)'F')
                        {
                            validite = false;
                        }
                    }
                }
            }
            return validite;
        }
        public frmConversions()
        {
            InitializeComponent();
        }

        private void txtBinaireADec_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox binaire = txtBinaireADec;
            if (!ValiderDimensionBin(binaire.Text) || !ValiderBinaire(binaire.Text))
            {
                _BinaireADecValidite = false;
                binaire.BackColor = Color.Pink;
            }
            else
            {
                _BinaireADecValidite = true;
                binaire.BackColor = Color.White;
            }
        }

        private void btnBinaireDecimal_Click(object sender, EventArgs e)
        {
            if (_BinaireADecValidite)
            {
                txtDecimalDeBin.Text = BinADec(txtBinaireADec.Text).ToString();
            }
        }

        private void txtDecimalABin_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox deciml = txtDecimalABin;
            if (!ValiderDimensionDec(deciml.Text) || !ValiderDecimal(deciml.Text))
            {
                _DecimalABinValidite = false;
                deciml.BackColor = Color.Pink;
            }
            else
            {
                _DecimalABinValidite = true;
                deciml.BackColor = Color.White;
            }
        }

        private void btnDecimalBinaire_Click(object sender, EventArgs e)
        {
            if (_DecimalABinValidite)
            {
                txtBinaireDeDec.Text = DecABin(int.Parse(txtDecimalABin.Text));
            }
        }

        private void txtHexaADec_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox hexa = txtHexaADec;
            if (!ValiderDimensionHex(hexa.Text) || !ValiderHexa(hexa.Text))
            {
                _HexaADecValidite = false;
                hexa.BackColor = Color.Pink;
            }
            else
            {
                _HexaADecValidite = true;
                hexa.BackColor = Color.White;
            }
        }

        private void btnHexaDecimal_Click(object sender, EventArgs e)
        {
            if (_HexaADecValidite)
            {
                txtDecimalDeHexa.Text = HexADec(txtHexaADec.Text).ToString();
            }
        }

        private void txtDecimalAHexa_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox deciml = txtDecimalAHexa;
            if (!ValiderDimensionDec(deciml.Text) || !ValiderDecimal(deciml.Text))
            {
                _DecimalAHexValidite = false;
                deciml.BackColor = Color.Pink;
            }
            else
            {
                _DecimalAHexValidite = true;
                deciml.BackColor = Color.White;
            }
        }

        private void btnDecimalHexa_Click(object sender, EventArgs e)
        {
            if (_DecimalAHexValidite)
            {
                txtHexaDeDec.Text = DecAHex(int.Parse(txtDecimalAHexa.Text));
            }
        }

        private void txtBinAHexa_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox binaire = txtBinAHexa;
            if (!ValiderDimensionBin(binaire.Text) || !ValiderBinaire(binaire.Text))
            {
                _BinaireAHexValidite = false;
                binaire.BackColor = Color.Pink;
            }
            else
            {
                _BinaireAHexValidite = true;
                binaire.BackColor = Color.White;
            }
        }

        private void btnBinaireHexa_Click(object sender, EventArgs e)
        {
            if (_BinaireAHexValidite)
            {
                txtHexaDeBin.Text = BinAHex(txtBinAHexa.Text);
            }
        }

        private void txtHexaABin_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox hexa = txtHexaABin;
            if (!ValiderDimensionHex(hexa.Text) || !ValiderHexa(hexa.Text))
            {
                _HexaABinValidite = false;
                hexa.BackColor = Color.Pink;
            }
            else
            {
                _HexaABinValidite = true;
                hexa.BackColor = Color.White;
            }
        }

        private void btnHexaBinaire_Click(object sender, EventArgs e)
        {
            if (_HexaABinValidite)
            {
                txtBinDeHexa.Text = HexABin(txtHexaABin.Text);
            }
        }
    }
}
