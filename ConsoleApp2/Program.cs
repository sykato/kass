class Person
{
    private string name;
    private string secondname;
    private DateTime BDate;

    public Person(string studentname, string studentsecondname, System.DateTime studentBDate)
    {
        this.name = studentname;
        this.secondname = studentsecondname;
        this.BDate = studentBDate;
    }

    public Person()
    { }

    private string stdname;
    public string Name
    {
        get
        {
            return name;
        }


    }
    private string stdtsecondname;
    public string Secondname
    {
        get
        {
            return secondname;
        }

    }
    DateTime stdBDate
    {
        get
        {
            return BDate;
        }
    }

    int inststdBDate
    {
        get
        {
            return Convert.ToInt32(BDate);
        }

        set
        {
            BDate = Convert.ToDateTime(value);
        }
    }
    public override string ToString()
    {
        return "\n" + "Имя " + Name + "\n" + "Фамилия " + Secondname + "\n" + "Дата рождения: " + BDate + "\n";
    }
    public string ToShortString()
    {
        return "\n" + "Имя: " + Name + "\n" + "Фамилия: " + Secondname + "\n";
    }
    enum Education { Specialist, Bachelor, SecondEducation }
    class Exam
    {
        public string Discipline { get; set; }
        public int Rate { get; set; }
        public DateTime DateOfExam { get; set; }

        public Exam(string discipline, int rate, DateTime dateOfExam)
        {
            this.Discipline = discipline;
            this.Rate = rate;
            this.DateOfExam = dateOfExam;
        }

        public Exam()
        {
            this.Discipline = "";
            this.Rate = 0;
            this.DateOfExam = DateTime.Now;
        }

        public override string ToString()
        {
            return "Предмет:" + Discipline + " " + "Оценка:" + Rate + " " + "Дата экзамена:" + DateOfExam;
        }
    }
    class Student
    {
        private Person person;
        private Education education;
        private int group;
        private readonly List<Exam> exams = new List<Exam>();

        public Student(Person person, Education education, int group)
        {
            this.person = person;
            this.education = education;
            this.group = group;
        }

        public Student()
        {
            this.person = new Person();
            this.education = Education.Bachelor;
            this.group = 204;
        }

        public Person Person
        {
            get { return person; }
            set { person = value; }
        }

        public Education Education
        {
            get { return education; }
            set { education = value; }
        }

        public int Group
        {
            get { return group; }
            set { group = value; }
        }

        public Exam[] Exams
        {
            get { return exams.ToArray(); }

        }
        public double AvgRate
        {
            get
            {
                double sum = 0;
                foreach (Exam qwee in Exams)
                {
                    sum += qwee.Rate;
                }
                return exams.Count == 0 ? -1 : sum / exams.Count;
            }
        }

        public void AddExams(params Exam[] exams)
        {
            this.exams.AddRange(exams);
        }

        public override string ToString()
        {
            return string.Format("Человек: {0}\n Образование: {1}\n группа: {2}\n экзамены: {3}\n ", person, education, group, string.Join(", ", exams));
        }

        public string ToShortString()
        {
            return string.Format("Человек: {0}\n Образование: {1}\n группа: {2}\n Средний балл: {3:0.00}\n", person, education, group, AvgRate);
        }
    }
    private static void Main(string[] args)
    {
        Student std = new Student();
        std = new Student(new Person("Ivan", "Ivanov", new DateTime(1990, 4, 5)), Education.Bachelor, 3);
        Console.WriteLine(std.ToString());
        std.AddExams(new Exam("Русский", 4, new DateTime(2022, 2, 23)), new Exam("Программирование", 2, new DateTime(2022, 1, 12)));
        Console.WriteLine(std.ToString());

        Exam[] odnomer = new Exam[10];

        Exam[,] dvumer = new Exam[2, 5];

        Exam[][] stup = new Exam[4][];

        stup[0] = new Exam[1];

        stup[1] = new Exam[2];

        stup[2] = new Exam[3];

        stup[3] = new Exam[4];

        long milliseconds = DateTime.Now.Ticks;

        for (int p = 0; p < 10000; p++)

            for (int i = 0; i < 10; i++)

                odnomer[i] = new Exam();

        for (int i = 0; i < 10; i++)

            Console.WriteLine(odnomer[i] + " ");

        milliseconds = DateTime.Now.Ticks - milliseconds;

        Console.WriteLine("потраченное время: " + milliseconds + "\n");

        milliseconds = DateTime.Now.Ticks;

        for (int p = 0; p < 10000; p++)

            for (int i = 0; i < 2; i++)

                for (int j = 0; j < 5; j++)

                    dvumer[i, j] = new Exam();

        Console.WriteLine("\n");

        for (int i = 0; i < 2; i++)

            for (int j = 0; j < 5; j++)

                Console.WriteLine(dvumer[i, j] + " ");

        milliseconds = DateTime.Now.Ticks - milliseconds;

        Console.WriteLine("потраченное время: " + milliseconds + "\n");

        milliseconds = DateTime.Now.Ticks;

        for (int p = 0; p < 10000; p++)

            for (int i = 0; i < 4; i++)

                for (int j = 0; j < i + 1; j++)

                    stup[i][j] = new Exam();

        Console.WriteLine("\n");

        for (int i = 0; i < 4; i++)

            for (int j = 0; j < i + 1; j++)

                Console.WriteLine(stup[i][j] + " ");

        milliseconds = DateTime.Now.Ticks - milliseconds;

        Console.WriteLine("потраченное время: " + milliseconds + "\n");

        milliseconds = DateTime.Now.Ticks;

        Console.ReadKey();

    }
}
