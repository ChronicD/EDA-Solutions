public String GetGrade(ArrayList marks)
{
int sum = 0;
   String grade = "";

foreach(int mark in marks)
{
sum = sum + mark;
}
float adv = (float) sum / (float) marks.Count;

if (adv >=90)
{
grade = "A";
}
       else if (adv >= 80)
       {
       grade = "B";
       }
       else if (adv >= 70)
       {
       grade = "C";
       }
       else if (adv >= 60)
       {
       grade = "D";
       }
       else
       {
       grade = "F";
       }
       return grade;
}