using System;

public class ExamResult
{
    public int Grade { get; private set; }
    public int MinGrade { get; private set; }
    public int MaxGrade { get; private set; }
    public string Comments { get; private set; }

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        if (grade < 0)
        {
            throw new ArgumentOutOfRangeException("Grade cannot be negative!");
        }
        if (minGrade < 0)
        {
            throw new ArgumentOutOfRangeException("minGrade cannot be negative!");
        }
        if (maxGrade <= minGrade)
        {
            throw new ArgumentException("maxGrade must be greater than minGrade!");
        }
        if (comments == null || comments == "")
        {
            throw new ArgumentNullException("Comments cannot be null or empty string!");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }
}
