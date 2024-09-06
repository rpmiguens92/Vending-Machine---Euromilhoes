namespace machine
{
    public partial class Form1 : Form
    {
        #region variables

        //variaveis para produtos
        double cafe = 0.25;
        double cha = 0.20;
        double capuccino = 0.35;
        double chocolate = 0.30;
        //variaveis para o troco
       
        double amount;
        double inserted_amount;
        double change;

        //timer
        int time_remaining = 0;

        #endregion

        #region coin_counter 
        int coin_counter2 = 25; //cada contador tem 25 moedas de cada valor para dar troco
        int coin_counter1 = 25;
        int coin_counter05 = 25;
        int coin_counter02 = 25;
        int coin_counter01 = 25;
        int coin_counter005 = 25;

        #endregion

        #region change_counter 
        int change2; //contador de cada tipo de moeda para fazer a contagem no troco
        int change1;
        int change05;
        int change02;
        int change01;
        int change005;

        #endregion


        private void timerMsgBox_Tick(object sender, EventArgs e)
        {
            time_remaining--;
            if (time_remaining == 0)
            {
                msgUser.Text = "Escolha o artigo e efectue pagamento!";
            }// quanto o timer = 0 volta à mensagem inicial
        }

        #region drinks

        private void btnCafe_Click(object sender, EventArgs e)
        {

            time_remaining = 5;
            timerMsgBox.Start();
            msgUser.Text = $"O Café custa {cafe}€.Insira moedas!";
            //ao selecionar o artigo despoleta uma mensagemm comm o valor do artigo por 5s
            if (inserted_amount > 0)
            {
                timerMsgBox.Stop();
                msgUser.Text = $"Seleccionou café.";
            }
        }
        private void btnCha_Click(object sender, EventArgs e)
        {
            time_remaining = 5;
            timerMsgBox.Start();
            msgUser.Text = $"O Chá custa {cha}€.Insira moedas!";
        }

        private void btnChoco_Click(object sender, EventArgs e)
        {
            time_remaining = 5;
            timerMsgBox.Start();
            msgUser.Text = $"O Chocolate custa {chocolate}€.Insira moedas!";
        }

        private void btnCapuccino_Click(object sender, EventArgs e)
        {
            time_remaining = 5;
            timerMsgBox.Start();
            msgUser.Text = $"O Capuccino custa {capuccino}€.Insira moedas!";
        }

        #endregion


        #region inserted_amount

        private void btn2_Click(object sender, EventArgs e)
        {
            inserted_amount = inserted_amount + 2; //soma o valor inserido
            coin_counter2++; // incrementa o contador da moeda introduzida
            txtInsertedAmount.Text = $"O valor inserido foi: {inserted_amount}€"; //msg do valor inserido
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inserted_amount = inserted_amount + 1;
            coin_counter1++;
            txtInsertedAmount.Text = $"O valor inserido foi: {inserted_amount}€";
        }

        private void btn050_Click(object sender, EventArgs e)
        {
            inserted_amount = inserted_amount + 0.5;
            coin_counter05++;
            txtInsertedAmount.Text = $"O valor inserido foi: {inserted_amount}€";
        }

        private void btn020_Click(object sender, EventArgs e)
        {
            inserted_amount = inserted_amount + 0.2;
            coin_counter02++;
            txtInsertedAmount.Text = $"O valor inserido foi: {inserted_amount}€";
        }

        private void btn010_Click(object sender, EventArgs e)
        {
            inserted_amount = inserted_amount + 0.1;
            coin_counter01++;
            txtInsertedAmount.Text = $"O valor inserido foi: {inserted_amount}€";
        }

        private void btn005_Click(object sender, EventArgs e)
        {
            inserted_amount = inserted_amount + 0.05;
            coin_counter005++;
            txtInsertedAmount.Text = $"O valor inserido foi: {inserted_amount}€";
        }

        #endregion

        private void txtInsertedAmount_TextChanged(object sender, EventArgs e)
        {
            txtInsertedAmount.Text = $"O valor inserido foi: {inserted_amount}€";
        }



        



        private void btnchoice_Click(object sender, EventArgs e)
        {

        }
    }
}
