namespace GuardiansSophos.DTO
{
    public class DiaryDTO
    {
        public string IdDiary { get; set; }
        public DateTime InitHour { get; set; }
        public DateTime EndHour { get; set; }
        public string NameActivity { get; set; }
        public string Description { get; set; }
    }
}
