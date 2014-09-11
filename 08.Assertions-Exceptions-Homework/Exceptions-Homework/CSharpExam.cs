using System;

public class CSharpExam : Exam
{
    private const int MAX_SCORE = 100;

    public int Score { get; private set; }

    public CSharpExam(int score)
    {
        if (score < 0)
        {
            throw new ArgumentOutOfRangeException("Score cannot be negative!");
        }

        this.Score = score;
    }

    public override ExamResult Check()
    {
        if (Score < 0 || Score > MAX_SCORE)
        {
            throw new ArgumentOutOfRangeException(string.Format("Score must be between 0 and {0}.", MAX_SCORE));
        }
        else
        {
            return new ExamResult(this.Score, 0, MAX_SCORE, "Exam results calculated by score.");
        }
    }
}
