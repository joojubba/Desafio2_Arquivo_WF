namespace Desafio02_WF
{
    public partial class FormDesafio02 : Form
    {
        private Random random = new Random();
        Garagem garagem = new Garagem();
        public FormDesafio02()
        {
            InitializeComponent();
        }
       

        private void textBoxPlacaVeiculo_TextChanged(object sender, EventArgs e)
        {
             
        }
        private void buttonEntrada_Click(object sender, EventArgs e)
        {
            if (textBoxPlacaVeiculo.Text.Equals(""))
            {
                MessageBox.Show("Informe a Placa", "Alerta!");
                return;
            }
            if (textBoxHora.Text.Equals(""))
            {
                MessageBox.Show("Informe a Hora", "Alerta!");
                return;
            }

            textBoxPlacaVeiculo.Text = textBoxPlacaVeiculo.Text.ToUpper();
            string placaVeiculo = textBoxPlacaVeiculo.Text;
            
            string hora = textBoxHora.Text;           
            DateTime horario = DateTime.Parse(hora);   
            if (!garagem.horarioGaragem(horario))
            {
                MessageBox.Show("Estacionamento Fechado!", "Alerta!");
                return;
            }
  
            if (!garagem.temLugar())
            {
                MessageBox.Show("Garagem Lotada, aguarde a vaga liberar!", "Alerta!");
                return;
            }
     
            if (garagem.jaCadastrado(placaVeiculo))
            {
                MessageBox.Show("Veículo está na garagem!", "Alerta!");
                return;
            }
            else
            {
                if (placaVeiculo.Length != 7)
                {
                    MessageBox.Show("A placa do veículo deve ter 7 caracteres!", "Alerta!");
                    return;                   
                }
                else
                {
                    DateTime horaEntrada = DateTime.Parse(textBoxHora.Text);
                    Veiculo veiculo = new Veiculo(placaVeiculo, DateTime.Now, horaEntrada);
                    garagem.EntradaVeiculo(veiculo, horaEntrada);

                    Persistencia.gravarArquivoVeiculosEntrada(garagem.ListaEntrada);
                    Listagem();
                }
            }     
            textBoxPlacaVeiculo.Text = "";
            textBoxHora.Text = "";
        }
        private void Listagem()
        {
             listBoxListaVeiculosEntrada.Items.Clear();
            foreach (Veiculo veiculo in garagem.ListaEntrada)
            {
               listBoxListaVeiculosEntrada.Items.Add($"Placa: {veiculo.PlacaVeiculo} - Data de Entrada: {veiculo.DataEntrada:dd/MM/yyyy} " +
                   $"- Hora de Entrada: {veiculo.HoraEntrada:HH:mm}");             
            }
            listBoxListaVeiculosSaida.Items.Clear();
            foreach (Veiculo veiculo in garagem.ListaSaida)
            {
               
                listBoxListaVeiculosSaida.Items.Add($"Placa: {veiculo.PlacaVeiculo} - Data de Entrada: {veiculo.DataEntrada:dd/MM/yyyy} " +
                    $"- Hora de Entrada: {veiculo.HoraEntrada:HH:mm} - Tempo de Permanência: {veiculo.TempoPermanencia} min " +
                   $"- Valor Cobrado: R$ {veiculo.ValorCobrado}");
                              
            }
        }
        private void textBoxHora_TextChanged(object sender, EventArgs e)
        {
             if (textBoxHora.Text.Length == 4)
             {
                 textBoxHora.Text = textBoxHora.Text.Insert(2, ":");
             }     
        }
        private void buttonSaida_Click(object sender, EventArgs e)
        {
            textBoxPlacaVeiculo.Text = textBoxPlacaVeiculo.Text.ToUpper();
            string placaVeiculo = textBoxPlacaVeiculo.Text;

            string hora = textBoxHora.Text;
            DateTime horario = DateTime.Parse(hora);

            Veiculo veiculo = null;
            foreach (Veiculo item in garagem.ListaEntrada)
            {
                if (item.PlacaVeiculo == placaVeiculo)
                {
                    veiculo = item;
                    break;
                }
            }
            if (veiculo != null)
            {
                if(horario < veiculo.HoraEntrada)
                {
                    MessageBox.Show("Horário incompátivel!", "Alerta!");

                }
                else
                {
                    DateTime horaSaida = DateTime.Parse(textBoxHora.Text);
                    garagem.SaidaVeiculo(veiculo, horaSaida);
                    MessageBox.Show($"Placa: {veiculo.PlacaVeiculo} - Tempo de Permanência: {veiculo.TempoPermanencia} min " +
                       $"- Valor Cobrado: R$ {veiculo.ValorCobrado}", "Atenção:");
                    Listagem();
                }
               
            }
            textBoxPlacaVeiculo.Text = "";
            textBoxHora.Text = "";
        }

        private void FormDesafio02_Load(object sender, EventArgs e)
        {
         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int r  = random.Next(0, 255);
            int g  = random.Next(0, 255);
            int b = random.Next(0, 255);

            Color color = Color.FromArgb(r,g,b);
            this.labelDataAtual.ForeColor = color;
            this.labelDataAtual.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
