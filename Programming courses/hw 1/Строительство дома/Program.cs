using System.Xml.Linq;
using Строительство_дома.Дом;
using Строительство_дома.Строители;

//для взаимодейсвтие между house и worker желательно создать промежуточный класс
Worker w1 = new Worker("Абрамов Алексей Игорович", "Стройка"); 
Worker w2= new Worker("Иванов Григорий Паренанович", "Стройка");
Worker w3 = new Worker("Васильевич Иван Сергеевич", "Стройка");
TeamLeader T = new TeamLeader("Григорянович Руслан Игорович", "Стройка");
House h = new House();

Team team = new Team();


//сделано костыльно (для идеала классы нужно переделать и добавить прокси класс для (взаимодействие team + house))
team.workers.Add(w1);
team.workers.Add(w2);
team.workers.Add(w3);
team.workers.Add(T);

team.StartBuildHouse(h);
team.StartBuildHouse(h);
team.StartBuildHouse(h);
team.StartBuildHouse(h);
team.StartBuildHouse(h);
team.StartBuildHouse(h);


Console.WriteLine(T.jobs(h));


