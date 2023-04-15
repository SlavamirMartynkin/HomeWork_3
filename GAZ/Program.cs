int maxP = 100000; // максимальное давление 100кПа
int minP = 1;  // начальное давление 1 Па
int minT = 15; // начальная температура
int maxT; // максимальная температура
int t = 0; //время

System.Console.Write("До взрыва сосуда с газом осталось: ");
System.Console.Write(string.Join(":", TimeConverter(TimeToBoom(minT, maxP, minP))));
System.Console.WriteLine(" секунд.");

int TimeToBoom(int minT, int maxP, int minP)
{
maxT = minT * maxP / minP;

for (int T = minT; T < maxT; T++)
{
    t++;
}
return t++;
}

int [] TimeConverter(int t)
{
    int day;
    int hours;
    int minutes;
    int seconds;

    day = t / 60 / 60 / 24 ;
    hours = t / 60 / 60 % 24;
    minutes = t / 60 % 60;
    seconds = t % 60;
    
    int [] Time = new[] {day, hours, minutes, seconds};
    return Time;

}



