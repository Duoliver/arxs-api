namespace DTOs
{
    public class CreateScoreSystemRequestDTO
    {
        public string Alias { get; set; } = null!;
        public List<int> Scores { get; set; } = [];
    }
}