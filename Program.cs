using services.Pomodoro;
using UI.pomodoro;

class Program
{
    static void Main()
    {
        UIPomodoro p = new UIPomodoro();
        p.Start();
        
        int[] data =  p.ShowConsoleInputs();

        Pomodoro c = new Pomodoro(data[0], data[1], data[2]); 
    }
}