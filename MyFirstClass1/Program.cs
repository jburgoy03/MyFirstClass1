

var Evan = new MyFirstClass1.TQLStudent("Evan", "Mercurio", 4); //instances
var Evangit = new MyFirstClass1.Assessment()
{
    Topic = "Git/Github",
    Points = 110,
    Taken = DateTime.Now,
};
Evan.GitGithubAssessment = Evangit;

Evan.HappyAnniversary();

Console.WriteLine(Evan.Print());


var Jared = new MyFirstClass1.TQLStudent("Jared", "Burgoyne", 1);

Console.WriteLine(Jared.Print());

var git = new MyFirstClass1.Assessment() { Topic = "Git/GitHub", Points = 110, Taken = DateTime.Now };
var sql = new MyFirstClass1.Assessment() { Topic = "SQL", Points = 110, Taken = DateTime.Now };
var csharp = new MyFirstClass1.Assessment() { Topic = "CSharp", Points = 110, Taken = DateTime.Now };
var angular = new MyFirstClass1.Assessment() { Topic = "Angular", Points = 110, Taken = DateTime.Now };
var java = new MyFirstClass1.Assessment() { Topic = "Java", Points = 110, Taken = DateTime.Now };
var test = new MyFirstClass1.TQLStudent()
{
    FirstName = "Test",
    YearsOfService = 99,
    GitGithubAssessment = git,
    SQLAssessment = sql,
    CSharp = csharp,
    Java = java,
    Angular = angular,
};

Console.WriteLine(test.Print());



