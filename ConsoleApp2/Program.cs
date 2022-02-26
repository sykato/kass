class person
{
    public string name
    { get; set; }
    public string surname
    { get; set; }
    public DateTime daterod
    { get; set; }
    public person (string name, string surname, DateTime daterod) 
    {
        this.name = name;
        this.surname = surname;
        this.daterod = daterod;
    }
enum Education
{
    Specialist,
    Вachelor,
    SecondEducation
}
class exam
{
        public string predmet;
        public int ocenka;
        public DateTime dateexam;
    public exam(string predmet, int ocenka, DateTime dateexam)
    {
        this.predmet = predmet;
        this.ocenka = ocenka;
        this.dateexam = dateexam;
    }
    private exam()
    {
        predmet = "defolt_predmet";
        ocenka = 5;
        dateexam = new DateTime(26, 02, 22);
    }
        public string ToFullstring()
        {
            return string.Format(predmet, ocenka, dateexam);
        }
}

class student
{
        private person person;
        private Education education;
        private int nomergrypp;
}