class Person
{
    public string name
    { get; set; }
    public string surname
    { get; set; }
    public DateTime dateroj
    {
        get { return dateroj; }
        set { dateroj = value; }
    }
    public Person(string name, string surname, DateTime dateroj)
    {
        this.name = name;
        this.surname = surname;
        this.dateroj = dateroj;
    }
    private Person()
    {
        name = "Неуказон";
        surname = "Неуказон";
        dateroj = new DateTime(0, 0, 0);
    }
    public string ToFullString()
    {
        return string.Format(name, surname, dateroj);
    }
}
enum Education{Specialist,Вachelor,SecondEducation}
class Exam
{
    public string predmet;
    public int ocenka;
    public DateTime dateexam;
    public Exam(string predmet, int ocenka, DateTime dateexam)
    {
        this.predmet = predmet;
        this.ocenka = ocenka;
        this.dateexam = dateexam;
    }
    private Exam()
    {
        predmet = "неуказон";
        ocenka = 3;
        dateexam = new DateTime(05, 03, 22);
    }
    public string ToFullstring()
    {
        return string.Format(predmet, ocenka, dateexam);
    }
}
class student
{
    private Person person;
    private Education education;
    private int nomgrupp;
    private Exam[] exam;

    private student(Person person, Education education, int nomgrupp, Exam[] exam)
    {
        this.person = person;
        this.education = education;
        this.nomgrupp = nomgrupp;
        this.exam = exam;
    }
    private student()
    {
        person = new Person();
        education = new Education();
        nomgrupp = new int();
        exam = new Exam[1];
    }
    
}
