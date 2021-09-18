using System;
using System.Windows.Forms;

namespace TP7
{
    public partial class frmTP7 : Form
    {
        public frmTP7()
        {
            InitializeComponent();
        }

        private void btnAfficherAlphabetEncode_Click(object sender, EventArgs e)
        {
            // Lecture des entrees
            int CodeCesar = LireCodeCesar(txtCodeCesar.Text);
            string Alphabet = LireChaine(lblAlphabet.Text);

            // Validation des entrees
            if (!ValiderEntrees(CodeCesar, Alphabet))
            {
                return;
            }

            // Ecriture de la sortie
            lblAlphabetEncode.Text = EncoderChaine(Alphabet, CodeCesar);
        }

        private void btnAfficherPhraseEncodee_Click(object sender, EventArgs e)
        {
            // Lecture des entrees
            int CodeCesar = LireCodeCesar(txtCodeCesar.Text);
            string PhraseAEncoder = LireChaine(txtPhraseAEncoder.Text);

            // Validation des entrees
            if (!ValiderEntrees(CodeCesar, PhraseAEncoder))
            {
                return;
            }

            // Ecriture de la sortie
            txtPhraseEncodee.Text = EncoderChaine(PhraseAEncoder, CodeCesar);
        }

        private void btnAfficherPhraseDecodee_Click(object sender, EventArgs e)
        {
            // Lecture des entrees
            int CodeCesar = LireCodeCesar(txtCodeCesar.Text);
            string PhraseCodee = LireChaine(txtPhraseCodee.Text);

            // Validation des entrees
            if (!ValiderEntrees(CodeCesar, PhraseCodee))
            {
                return;
            }

            // Ecriture de la sortie
            txtPhraseDecodee.Text = DecoderChaine(PhraseCodee, CodeCesar);
        }

        private int LireCodeCesar(string Code)
        {
            int CodeLu;
            bool EstValide = int.TryParse(Code, out CodeLu);

            if (!EstValide)
            {
                CodeLu = -1;
            }

            return CodeLu;
        }

        private string LireChaine(string Chaine)
        {
            string ChaineLu = Chaine;
            return ChaineLu;
        }

        private bool ValiderEntrees(int Code, string Chaine)
        {
            if (!ValiderCodeCesar(Code))
            {
                AfficherExceptionCodeCesar();
                return false;
            }

            if (!ValiderChaine(Chaine))
            {
                AfficherExceptionChaine();
                return false;
            }

            return true;
        }

        private bool ValiderCodeCesar(int Code)
        {
            if (Code < 0 || Code >= lblAlphabet.Text.Length)
            {
                return false;
            }

            return true;
        }

        private void AfficherExceptionCodeCesar()
        {
            MessageBox.Show("Le code César est invalide (doit être un entier positif inférieur à 26)", "Validation du Code César", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool ValiderChaine(string Chaine)
        {
            if (Chaine.Length == 0)
            {
                return false;
            }

            return true;
        }

        private void AfficherExceptionChaine()
        {
            MessageBox.Show("La chaine de caractères entrée est invalide (doit contenir au moins 1 caractère)", "Validation de la Chaine de Caractères", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private string EncoderChaine(string Chaine, int Code)
        {
            string ChaineEncodee= "";
            foreach (char Caractere in Chaine)
            {
                ChaineEncodee += EncoderCaractere(Caractere, Code);
            }

            return ChaineEncodee;
        }

        private char EncoderCaractere(char Caractere, int Code)
        {
            int IndexDeCaractereDansAlphabet = lblAlphabet.Text.IndexOf(Caractere.ToString().ToUpper());

            char CaractereEncode;
            if (IndexDeCaractereDansAlphabet < 0)
            {
                CaractereEncode = '_';
            }
            else if (IndexDeCaractereDansAlphabet + Code < lblAlphabet.Text.Length)
            {
                CaractereEncode = lblAlphabet.Text[IndexDeCaractereDansAlphabet + Code];
            }
            else
            {
                CaractereEncode = lblAlphabet.Text[IndexDeCaractereDansAlphabet + Code - lblAlphabet.Text.Length];
            }

            return CaractereEncode;
        }

        private string DecoderChaine(string Chaine, int Code)
        {
            string ChaineDecodee = "";

            foreach (char Caractere in Chaine)
            {
                ChaineDecodee += DecoderCaractere(Caractere, Code);
            }

            return ChaineDecodee;
        }

        private char DecoderCaractere(char Caractere, int Code)
        {
            int IndexDeCaractereDansAlphabet = lblAlphabet.Text.IndexOf(Caractere.ToString().ToUpper());

            char CaractereDecode;
            if (IndexDeCaractereDansAlphabet < 0)
            {
                CaractereDecode = '_';
            }
            else if (IndexDeCaractereDansAlphabet - Code >= 0)
            {
                CaractereDecode = lblAlphabet.Text[IndexDeCaractereDansAlphabet - Code];
            }
            else
            {
                CaractereDecode = lblAlphabet.Text[IndexDeCaractereDansAlphabet - Code + lblAlphabet.Text.Length];
            }

            return CaractereDecode;
        }
    }
}
