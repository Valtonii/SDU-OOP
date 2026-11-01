int[] grades = [4, 7, 02, 00, 10, 4, 12];

int GetGrade (int courseid){
    int grade = grades[courseid];
    if (grade >= 2) {

        return grade;
    } else {
        throw new Exception("Bum");
    }

}

int count = 0;
int sum = 0;

for (int courseid = 0; courseid<grades.Length; courseid++){
    try {
        int gradeResult = GetGrade(courseid);
        count++;
        sum += gradeResult;
    } catch (Exception){
    }
}
Console.WriteLine((double)sum / count);
