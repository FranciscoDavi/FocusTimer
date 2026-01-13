using System.Runtime;

namespace UI.pomodoro
{
    public class UIPomodoro
    {
        public int TimerLine {get; private set;}
        //screens
        public void Start()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            string text = "CHICODORO";
            DrawHeader(text, ConsoleColor.Cyan);
            Thread.Sleep(2000);
        }
        public int[] ShowConsoleInputs()
        {
            int[] data = new int[3];

            Console.WriteLine("Digite seu periodo de estudo: ");
            data[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu periodo de pausa: ");
            data[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero de sessoes: ");
            data[2] = int.Parse(Console.ReadLine());

            return data;
        }

        public void ShowFocusScreen()
        {
            string headerText =  "FOCUS TIMER 🍅";
            DrawHeader(headerText, ConsoleColor.Green);
          
            TimerLine = Console.CursorTop + 1; //guarda a linha do timer
        }

        public void ShowRestScreen()
        {
            string headerText =  "REST TIMER 🍅";
            DrawHeader(headerText, ConsoleColor.Blue);

            TimerLine = Console.CursorTop + 1; //guarda a linha do timer
        }
        
        public void ShowEndScreen()
        {
            string headerText =  "🎉 Pomodoro finalizado!";
            DrawHeader(headerText, ConsoleColor.Yellow);
            Console.ResetColor();
            Console.Beep();
        }
        
        //Components
        public void ShowTimer(int minutosRestantes, int segundosRestantes)
        {
            string[] anim = { "⏳", "⌛" };
            string timeText = $"{anim[segundosRestantes % 2]} {minutosRestantes:D2}:{segundosRestantes:D2}";
            WriteCentered(timeText, TimerLine);
        }

        //Helpers
        private void WriteCentered(string text, int line)
        {
            int windowWidth = Console.WindowWidth;
            int left = (windowWidth - text.Length) / 2;

            Console.SetCursorPosition(Math.Max(left, 0), line);
            Console.Write(text);
        }           
        private void DrawSeparator()
        {
            Console.WriteLine(new string('=', Console.WindowWidth));
        }

        private void DrawHeader(string title, ConsoleColor color)
        {
            Console.Clear();
            Console.ForegroundColor = color;

            DrawSeparator();
            WriteCentered(title, Console.CursorTop);
            Console.WriteLine();
            DrawSeparator();
        }
    }
}