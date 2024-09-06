using System.Runtime.Versioning;
using System.Windows.Forms;
using System.Media;

namespace vending_machine;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) //quando inicia o form a lblAux está vazia
    {
        lblAux.Text = "";
    }

    #region variables

    //variaveis para o troco
    double inserted_amount, change, price;

    //contador de cada tipo de moeda para fazer a contagem no troco
    int change2 = 0;
    int change1 = 0;
    int change05 = 0;
    int change02 = 0;
    int change01 = 0;
    int change005 = 0;

    //cada contador tem n moedas de cada valor para dar troco
    int coin_counter2 = 4;
    int coin_counter1 = 3;
    int coin_counter05 = 5;
    int coin_counter02 = 3;
    int coin_counter01 = 2;
    int coin_counter005 = 2 ;

    System.Media.SoundPlayer moedas = new System.Media.SoundPlayer(Properties.Resources.insert_coin);//inserção de moedas
    System.Media.SoundPlayer troco =  new System.Media.SoundPlayer(Properties.Resources.give_change);//troco

    #endregion

    //ao iniciar o programa tem uma msg de iniciação.
    //as variaveis de valor inserido e troco estão zeradas.
    //1º é cedido acesso só aos botoes das bebidas
    //desativa-se o botão de iniciação do programa
    //apos seleccao da bebida dá se visibilidade aos botoes das moedas
    //apos introduzir as moedas os botoes confirmar pedido e cancelar surgem
    //ao premir confirmar pedido é gerado o troco e o sistema reinicia com timer 5s
    //se nao introduzir montante suficiente o programa devolve o troco e reinicia
    //se nao houver moedas suficientes o programa devolve o valor e reinicia
    //ao premir cancelar o programa devolve o troco

    private void btnstart_Click(object sender, EventArgs e)
    {
        msgUser.Text = "Escolha o produto e insira as moedas!";// mensagem de instrução para o utilizador
        lblAux.Text = null;
        txtInsertedAmount.Text = null;
        inserted_amount = 0;
        change = 0;

        change2 = 0;//há necessidade de zerar os contadores e variaveis para nao influenciar o troco
        change1 = 0;
        change05 = 0;
        change02 = 0;
        change01 = 0;
        change005 = 0;

        visible_buttons_drinks();//metodo que disponibiliza os botoes referentes às bebidas disponiveis
    }

    #region drinks
    private void btnCafe_Click(object sender, EventArgs e)
    {
        price = 0.25;
        msgUser.Text = $"O Café custa {price}€.";
        visible_buttons_coins();
    }
    private void btnCha_Click(object sender, EventArgs e)
    {
        price = 0.20;
        msgUser.Text = $"O Chá custa {price}€.";
        visible_buttons_coins();
    }
    private void btnChoco_Click(object sender, EventArgs e)
    {
        price = 0.35;
        msgUser.Text = $"O Chocolate custa {price}€.";
        visible_buttons_coins();
    }
    private void btnCapuccino_Click(object sender, EventArgs e)
    {
        price = 0.30;
        msgUser.Text = $"O Cappuccino custa {price}€.";
        visible_buttons_coins();
    }
    #endregion

    #region inserted_amount_contadores
    private void btn2_Click(object sender, EventArgs e)
    {
        inserted_amount = inserted_amount + 2; //soma o valor inserido
        coin_counter2++; // incrementa o contador da moeda introduzida
        txtInsertedAmount.Text = $"Valor inserido: {Math.Round(inserted_amount, 2)}€"; //msg do valor inserido

        btnChoice.Visible = true; //dá visibilidade aos botoes de confirmação do pedido e cancelar
        btnCancel.Visible = true;
        moedas.Play(); //som de moedas
    }
    private void btn1_Click(object sender, EventArgs e)
    {
        inserted_amount = inserted_amount + 1;
        coin_counter1++;
        txtInsertedAmount.Text = $"Valor inserido: {Math.Round(inserted_amount, 2)}€"; //msg do valor inserido
        btnChoice.Visible = true;
        btnCancel.Visible = true;
        moedas.Play();
    }
    private void btn050_Click(object sender, EventArgs e)
    {
        inserted_amount = inserted_amount + 0.5;
        coin_counter05++;
        txtInsertedAmount.Text = $"Valor inserido: {Math.Round(inserted_amount, 2)}€";
        btnChoice.Visible = true;
        btnCancel.Visible = true;
        moedas.Play();
    }
    private void btn020_Click(object sender, EventArgs e)
    {
        inserted_amount = inserted_amount + 0.2;
        coin_counter02++;
        txtInsertedAmount.Text = $"Valor inserido: {Math.Round(inserted_amount, 2)}€";
        btnChoice.Visible = true;
        btnCancel.Visible = true;
        moedas.Play();
    }
    private void btn010_Click(object sender, EventArgs e)
    {
        inserted_amount = inserted_amount + 0.1;
        coin_counter01++;
        txtInsertedAmount.Text = $"Valor inserido: {Math.Round(inserted_amount, 2)}€";
        btnChoice.Visible = true;
        btnCancel.Visible = true;
        moedas.Play();
    }
    private void btn005_Click(object sender, EventArgs e)
    {
        inserted_amount = inserted_amount + 0.05;
        coin_counter005++;
        txtInsertedAmount.Text = $"Valor inserido: {Math.Round(inserted_amount, 2)}€";
        btnChoice.Visible = true;
        btnCancel.Visible = true;
        moedas.Play();
    }
    #endregion

    private void btnChoice_Click(object sender, EventArgs e) //confirmar escolha, fazer o troco e tira visibilidade dos botoes
    {
        change = inserted_amount - price;// calculo do troco
        lblAux.Text = $"Troco:{Math.Round(change, 2)}€"; //label informativa do troco
        btnCancel.Enabled = false;//desabilita o botao cancel, apos confirmar nao pode cancelar
        lblCoins.Visible = false;
        timer1.Start();


        if (change >= 0)
        {
            while (change > 0) //enquanto o troco é >=0 vai fazer o troco consoante as condiçoes(>moeda~para <moeda)
            {
                if (change >= 2)
                {
                    if (coin_counter2 >= 1)//se o contador de moedas 2€ >0.. atribui o troco com moedas de 2
                    {
                        change = Math.Round(change - 2, 2);
                        coin_counter2--;
                        change2++;
                    }
                    else if (coin_counter2 < 1)//se o contador2€ = 0, passa aos contadoras moedas seguintes ate perfazer o troco 
                    {
                        change = Math.Round(change - 1, 2);
                        coin_counter1--;
                        change1++;
                    }
                    else if (coin_counter1 < 1)
                    {
                        change = Math.Round(change - 0.50, 2);
                        coin_counter05--;
                        change05++;
                    }
                    else if (coin_counter05 < 1)
                    {
                        change = Math.Round(change - 0.20, 2);
                        coin_counter02--;
                        change02++;
                    }
                    else if (coin_counter02 < 1)
                    {
                        change = Math.Round(change - 0.10, 2);
                        coin_counter01--;
                        change01++;
                    }
                    else if (coin_counter01 < 1)
                    {
                        change = Math.Round(change - 0.05, 2);
                        coin_counter005--;
                        change005++;
                    }
                    else if (coin_counter005 < 1)
                    {
                        troco.Play();
                        MessageBox.Show("Troco indisponível. Use a quantia certa. Lamentamos o incomodo.");
                        break;
                    }
                }
                else if (change >= 1)
                {
                    if (coin_counter1 >= 1)
                    {
                        change = Math.Round(change - 1, 2);
                        coin_counter1--;
                        change1++;
                    }
                    else if (coin_counter1 < 1)
                    {
                        change = Math.Round(change - 0.50, 2);
                        coin_counter05--;
                        change05++;
                    }
                    else if (coin_counter05 < 1)
                    {
                        change = Math.Round(change - 0.20, 2);
                        coin_counter02--;
                        change02++;
                    }
                    else if (coin_counter02 < 1)
                    {
                        change = Math.Round(change - 0.10, 2);
                        coin_counter01--;
                        change01++;
                    }
                    else if (coin_counter01 < 1)
                    {
                        change = Math.Round(change - 0.05, 2);
                        coin_counter005--;
                        change005++;
                    }
                    else if (coin_counter005 < 1)
                    {
                        troco.Play();
                        MessageBox.Show("Troco indisponível. Use a quantia certa. Lamentamos o incomodo.");
                        break;
                    }
                }
                else if (change >= 0.50)
                {
                    if (coin_counter05 >= 1)
                    {
                        change = Math.Round(change - 0.50, 2);
                        coin_counter05--;
                        change05++;
                    }
                    else if (coin_counter05 < 1)
                    {
                        change = Math.Round(change - 0.20, 2);
                        coin_counter02--;
                        change02++;
                    }
                    else if (coin_counter02 < 1)
                    {
                        change = Math.Round(change - 0.10, 2);
                        coin_counter01--;
                        change01++;
                    }
                    else if (coin_counter01 < 1)
                    {
                        change = Math.Round(change - 0.05, 2);
                        coin_counter005--;
                        change005++;
                    }
                    else if (coin_counter005 < 1)
                    {
                        troco.Play();
                        MessageBox.Show("Troco indisponível. Use a quantia certa. Lamentamos o incomodo.");
                        break;
                    }
                }
                else if (change >= 0.20)
                {
                    if (coin_counter02 >= 1)
                    {
                        change = Math.Round(change - 0.20, 2);
                        coin_counter02--;
                        change02++;
                    }
                    else if (coin_counter02 < 1)
                    {
                        change = Math.Round(change - 0.10, 2);
                        coin_counter01--;
                        change01++;
                    }
                    else if (coin_counter01 < 1)
                    {
                        change = Math.Round(change - 0.05, 2);
                        coin_counter005--;
                        change005++;
                    }
                    else if (coin_counter005 < 1)
                    {
                        troco.Play();
                        MessageBox.Show("Troco indisponível. Use a quantia certa. Lamentamos o incomodo.");
                        break;
                    }
                }
                else if (change >= 0.10)
                {
                    if (coin_counter01 >= 1)
                    {
                        change = Math.Round(change - 0.10, 2);
                        coin_counter01--;
                        change01++;
                    }
                    else if (coin_counter01 < 1)
                    {
                        change = Math.Round(change - 0.05, 2);
                        coin_counter005--;
                        change005++;
                    }
                    else if (coin_counter005 < 1)
                    {
                        troco.Play();
                        MessageBox.Show("Troco indisponível. Use a quantia certa. Lamentamos o incomodo.");
                        break;
                    }
                }
                else if (change >= 0.05)
                {
                    if (coin_counter005 >= 1)
                    {
                        change = Math.Round(change - 0.05, 2);
                        coin_counter005--;
                        change005++;
                    }
                    else if (coin_counter005 < 1)
                    {
                        MessageBox.Show("Troco indisponível. Use a quantia certa. Lamentamos o incomodo.");
                        troco.Play();
                        lblAux.Text = $"Valor devolvido{inserted_amount}";
                        inv_menus();
                        break;

                    }
                }
            }
            troco.Play();
            lblAux.Text = lblAux.Text + $"\n{change2} - moedas de 2€\n{change1} - moedas de 1€\n{change05} - moedas de 0.50€\n{change02} - moedas de 0.20€\n{change01} - moedas de 0.10€\n{change005} - moedas de 0.05€\n";
        }
        else
        {
            {
                lblAux.Text = $"Valor Insuficiente!";
                troco.Play();
                MessageBox.Show($"Valor devolvido: " + Math.Round(inserted_amount, 2) + "€");
            }
        }

    }

    private void btnCancel_Click(object sender, EventArgs e)
    //cancelar a compra, todos os botoes ficam indisponiveis e as variaveis tomam valor 0
    {
        troco.Play();
        MessageBox.Show($"Valor devolvido: {inserted_amount}€");

        #region alter_labels_cancel
        txtInsertedAmount.Text = "";
        msgUser.Text = "";
        lblAux.Text = "";
        inserted_amount = 0;
        change = 0;
        #endregion

        inv_menus();
    }//cancelar o pedido

    private void visible_buttons_coins() //torna visivel as moedas e labels relacionadas com valor/troco
    {
        btnCafe.Enabled = false;
        btnCapuccino.Enabled = false;
        btnCha.Enabled = false;
        btnChoco.Enabled = false;
        lblEntryDrink.Visible = false;


        btn2.Enabled = true;
        btn1.Enabled = true;
        btn050.Enabled = true;
        btn020.Enabled = true;
        btn010.Enabled = true;
        btn005.Enabled = true;
        btnChoice.Enabled = true;
        btnCancel.Enabled = true;
        lblCoins.Enabled = true;
        msgUser.Enabled = true;
        txtInsertedAmount.Enabled = true;

        txtInsertedAmount.Visible = true;
        lblCoins.Visible = true;
        btn2.Visible = true;
        btn1.Visible = true;
        btn050.Visible = true;
        btn020.Visible = true;
        btn010.Visible = true;
        btn005.Visible = true;
        btnChoice.Visible = true;
        btnCancel.Visible = true;
    }
    private void visible_buttons_drinks() //torna visivel as bebidas a selecionar
    {
        btnstart.Enabled = false;//tira o botão iniciar
        btnstart.Visible = false;

        msgUser.Enabled = true;//habilita labels/text box inerentes à seleccao de bebidas
        msgUser.Visible = true;
        lblEntryDrink.Enabled = true;
        lblEntryDrink.Visible = true;
        lblAux.Visible = true;


        btnCafe.Enabled = true;//habilita bebidas
        btnCapuccino.Enabled = true;
        btnCha.Enabled = true;
        btnChoco.Enabled = true;
        lblEntryDrink.Visible = true;
        btnCafe.Visible = true;
        btnCapuccino.Visible = true;
        btnChoco.Visible = true;
        btnCha.Visible = true;

    }
    private void inv_menus() //tira os menus visiveis apos confirmar o pedido ou cancelar por forma a iniciar o programa
    {
        btnCafe.Enabled = false; //enabled=false desabilita o botão
        btnCapuccino.Enabled = false;
        btnCha.Enabled = false;
        btnChoco.Enabled = false;
        btn2.Enabled = false;
        btn1.Enabled = false;
        btn050.Enabled = false;
        btn020.Enabled = false;
        btn010.Enabled = false;
        btn005.Enabled = false;
        btnChoice.Enabled = false;
        btnCancel.Enabled = false;

        msgUser.Enabled = false;
        txtInsertedAmount.Enabled = false;
        lblAux.Enabled = false;
        lblEntryDrink.Enabled = false;


        btnCafe.Visible = false; //visible=false poe o botao invisivel
        btnCapuccino.Visible = false;
        btnCha.Visible = false;
        btnChoco.Visible = false;
        btn2.Visible = false;
        btn1.Visible = false;
        btn050.Visible = false;
        btn020.Visible = false;
        btn010.Visible = false;
        btn005.Visible = false;
        btnChoice.Visible = false;
        btnCancel.Visible = false;
        msgUser.Visible = false;

        txtInsertedAmount.Visible = false;
        lblAux.Visible = false;
        lblCoins.Visible = false;
        lblEntryDrink.Visible = false;


        btnstart.Enabled = true;
        btnstart.Visible = true;
    }

    private void timer1_Tick(object sender, EventArgs e)//timer para reiniciar o programa apos confirmaçao do pedido
    {
        timer1.Stop();
        inv_menus();
    }
}
    
 