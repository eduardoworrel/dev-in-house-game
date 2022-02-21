public class BattleStoryTeller {
    private readonly string BackgroundColor = ConsoleColor.Red; 
    private readonly string ForegroundColor  = ConsoleColor.Black; 
    private readonly string Narrador = "[Batalha]: ";
    public static void Speak(string texto, int time = 1000){
        Console.BackgroundColor = this.BackgroundColor;
        Console.ForegroundColor = this.ForegroundColor;
        Console.WriteLine(Narrador + texto);
        Thread.Sleep(time);
        
    }
}