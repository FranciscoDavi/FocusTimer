using services.Pomodoro;
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite seu periodo de estudo: ");
        int t_estudo = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite seu periodo de pausa: ");
        int t_pausa = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o numero de sessões: ");
        int n_sessoes = int.Parse(Console.ReadLine());
        
        Pomodoro c = new Pomodoro(t_estudo, t_pausa, n_sessoes);
    }


}