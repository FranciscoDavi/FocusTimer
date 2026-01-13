using UI.pomodoro;

namespace services.Pomodoro
{
    public class Pomodoro
    {  
        private int tempoEstudo;
        private int tempoPausa;
        private int numeroSessoes;
        private  int segundosTotais;

        private UIPomodoro _UIPomodoro;

        public Pomodoro(int t_estudo, int t_pausa, int n_sessoes)
        {
            _UIPomodoro = new UIPomodoro();

            tempoEstudo = t_estudo;
            tempoPausa = t_pausa;
            numeroSessoes = n_sessoes;

            for(int i = 0; i < numeroSessoes; i++)
            {
                segundosTotais = tempoEstudo * 60;
                //
                _UIPomodoro.ShowFocusScreen();
                ContaTempo();

                if(i < numeroSessoes)
                {
                    _UIPomodoro.ShowRestScreen();
                    //Reseta para o tempo para o de pausa
                    segundosTotais = tempoPausa * 60;
                    ContaTempo();
                }
            }

            _UIPomodoro.ShowEndScreen(); 
        }

        private void ContaTempo()
        {
            while(segundosTotais > 0)
            {
                int minutosRestantes  = segundosTotais / 60;
                int segundosRestantes = segundosTotais % 60;

                _UIPomodoro.ShowTimer(minutosRestantes, segundosRestantes);
                
                Thread.Sleep(1000);
                segundosTotais--;
            }

        }

    }
}