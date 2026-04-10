using Game_analysis_MVPPattern.Model;
using Game_analysis_MVPPattern.Presenter;
using Game_analysis_MVPPattern.View;

class Program
{
    static void Main(string[] args)
    {
        var model = new GameLogic();
        var view = new SystemView();
        var presenter = new GamePresenter(view, model);

        Console.WriteLine(" == MVP Pattern 뽑기 시스템 구현 == \n");
        view.StartGameLoop();
    }
}
