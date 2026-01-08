
namespace services.Pomodoro
{
    public class Pomodoro
    {  
        private int tempoEstudo;
        private int tempoPausa;
        private int numeroSessoes;
        private  int segundosTotais;

        public Pomodoro(int t_estudo, int t_pausa, int n_sessoes)
        {
            tempoEstudo = t_estudo;
            tempoPausa = t_pausa;
            numeroSessoes = n_sessoes;

            for(int i = 0; i < numeroSessoes; i++)
            {
                Console.Clear();
                Console.WriteLine($"Sessão {i} de {numeroSessoes} - Estudo");

                segundosTotais = tempoEstudo * 60;
                ContaTempo("Tempo restante de estudo: ");

                if(i < numeroSessoes)
                {
                    Console.Clear();
                    Console.WriteLine("Hora da Pausa!");

                    //Reseta para o tempo para o de pausa
                    segundosTotais = tempoPausa * 60;

                    ContaTempo("Tempo restante de pausa: ");
                }
            }

            Console.WriteLine("🎉 Pomodoro finalizado!");
            Console.Beep();
        }

        private void ContaTempo(string msgText)
        {
            while(segundosTotais > 0)
            {
                int minutosRestantes  = segundosTotais / 60;
                int segundosRestantes = segundosTotais % 60;

                Console.Clear();
                Console.WriteLine(msgText);
                Console.WriteLine($"{minutosRestantes:D2}: {segundosRestantes:D2}");

                Thread.Sleep(1000);
                segundosTotais--;
            }
        }
    }
}