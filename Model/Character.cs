namespace Game_analysis_MVPPattern.Model{
    // 캐릭터 성급
    public enum Rarity{
        ThreeStar,
        FourStar,
        FiveStar
    }

    // 캐릭터 클래스
    public class Character{
        // 캐릭터 이름, 레어리티
        public string Name{get; set;}
        public Rarity Rarity{get; set;}

        // 등급을 별문자로 변환
        public string RarityStars => Rarity switch{
            Rarity.FiveStar => "★★★★★",
            Rarity.FourStar => "★★★★",
            Rarity.ThreeStar => "★★★",
            _ => "등급 없음"
        };

    public Character(string name, Rarity rarity){
        Name = name;
        Rarity = rarity;
        }
    }
}
