namespace Game_analysis_MVPPattern.Model{
  public interface IGameLogic{
    // player 재화 변경 이벤트
    public event Action<int> OnPlayerGemChanged;

    // 가챠 결과 이벤트
    public event Action<string> OnDrawResultLog;

    // 

}
