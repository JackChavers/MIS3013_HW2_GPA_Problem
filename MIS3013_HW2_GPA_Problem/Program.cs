// MIS 3013 HW2 Grade Problem


double overGPADbl = 0;

string outMesStr;
string inputMesStr;

// Accounting, Marketing, Economics and MIS
// A, B, C, D, F

// accounting
int accCreditHoursInt = 3;
int accPointValDbl = -1;
char accLetterGradeCh='E';
double accGradeDbl = 1;
outMesStr = "Please input the grade of accounting: ";
Console.Write(outMesStr);
inputMesStr = Console.ReadLine();
accGradeDbl = Convert.ToDouble(inputMesStr);
if (accGradeDbl >= 90)
{
    accLetterGradeCh = 'A';
    accPointValDbl = 4;
}
else if(accGradeDbl >+80)
{
    accLetterGradeCh = 'B';
    accPointValDbl = 3;
}
else if (accGradeDbl >=70)
{
    accLetterGradeCh = 'C';
    accPointValDbl = 2;
}
else if (accGradeDbl >=60)
{
    accLetterGradeCh = 'D';
    accPointValDbl = 1;
}
else
{
    accLetterGradeCh = 'F';
    accPointValDbl = 0;
}

// Marketing
int markCreditHoursInt = 3;
int markPointValDbl = -1;
char markLetterGradeCh = 'E';
double markGradeDbl = 1;
outMesStr = "Please input the grade of marketing: ";
Console.Write(outMesStr);
inputMesStr = Console.ReadLine();
markGradeDbl = Convert.ToDouble(inputMesStr);
if (markGradeDbl >= 90)
{
    markLetterGradeCh = 'A';
    markPointValDbl = 4;
}
else if (markGradeDbl > +80)
{
    markLetterGradeCh = 'B';
    markPointValDbl = 3;
}
else if (markGradeDbl >= 70)
{
    markLetterGradeCh = 'C';
    markPointValDbl = 2;
}
else if (markGradeDbl >= 60)
{
    markLetterGradeCh = 'D';
    markPointValDbl = 1;
}
else
{
    markLetterGradeCh = 'F';
    markPointValDbl = 0;
}

// Economics
int econCreditHoursInt = 3;
int econPointValDbl = -1;
char econLetterGradeCh = 'E';
double econGradeDbl = 1;
outMesStr = "Please input the grade of Economics: ";
Console.Write(outMesStr);
inputMesStr = Console.ReadLine();
econGradeDbl = Convert.ToDouble(inputMesStr);
if (econGradeDbl >= 90)
{
    econLetterGradeCh = 'A';
    econPointValDbl = 4;
}
else if (econGradeDbl > +80)
{
    econLetterGradeCh = 'B';
    econPointValDbl = 3;
}
else if (econGradeDbl >= 70)
{
    econLetterGradeCh = 'C';
    econPointValDbl = 2;
}
else if (econGradeDbl >= 60)
{
    econLetterGradeCh = 'D';
    econPointValDbl = 1;
}
else
{
    econLetterGradeCh = 'F';
    econPointValDbl = 0;
}


// MIS
int misCreditHoursInt = 3;
int misPointValDbl = -1;
char misLetterGradeCh = 'E';
double misGradeDbl = 1;
outMesStr = "Please input the grade of MIS: ";
Console.Write(outMesStr);
inputMesStr = Console.ReadLine();
misGradeDbl = Convert.ToDouble(inputMesStr);
if (misGradeDbl >= 90)
{
    misLetterGradeCh = 'A';
    misPointValDbl = 4;
}
else if (misGradeDbl > +80)
{
    misLetterGradeCh = 'B';
    misPointValDbl = 3;
}
else if (misGradeDbl >= 70)
{
    misLetterGradeCh = 'C';
    misPointValDbl = 2;
}
else if (misGradeDbl >= 60)
{
    misLetterGradeCh = 'D';
    misPointValDbl = 1;
}
else
{
    misLetterGradeCh = 'F';
    misPointValDbl = 0;
}

// overall GPA
overGPADbl = (accPointValDbl*accCreditHoursInt+markPointValDbl*markCreditHoursInt+econPointValDbl*econCreditHoursInt
    +misPointValDbl*misCreditHoursInt)*1.0 / (accCreditHoursInt+markCreditHoursInt+econCreditHoursInt+misCreditHoursInt);

outMesStr = "The letter grades:";
Console.WriteLine("\n");
Console.WriteLine(outMesStr);

outMesStr = String.Format($"Letter grade of Accounting: {accLetterGradeCh}");
Console.WriteLine(outMesStr);

outMesStr = String.Format($"Letter grade of Marketing: {markLetterGradeCh}");
Console.WriteLine(outMesStr);

outMesStr = String.Format($"Letter grade of Economics: {econLetterGradeCh}");
Console.WriteLine(outMesStr);

outMesStr = String.Format($"Letter grade of MIS: {misLetterGradeCh}");
Console.WriteLine(outMesStr);

// overall GPA
outMesStr = String.Format($"Overall GPA: {overGPADbl:F2}");
Console.WriteLine();
Console.WriteLine(outMesStr);




