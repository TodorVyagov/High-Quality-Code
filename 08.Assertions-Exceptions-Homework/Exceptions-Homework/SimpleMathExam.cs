using System;

public class SimpleMathExam : Exam
{
    private const int MAX_SOLVED_PROBLEMS = 10;

    public int ProblemsSolved { get; private set; }

    public SimpleMathExam(int problemsSolved)
    {
        if (problemsSolved < 0 || problemsSolved > MAX_SOLVED_PROBLEMS)
        {
            throw new ArgumentOutOfRangeException(
                string.Format("Solved problems must be between 0 and {0}!", MAX_SOLVED_PROBLEMS));
        }

        this.ProblemsSolved = problemsSolved;
    }

    public override ExamResult Check()
    {
        if (ProblemsSolved == 0)
        {
            return new ExamResult(2, 2, 6, "Bad result: nothing done.");
        }
        else if (ProblemsSolved == 1)
        {
            return new ExamResult(4, 2, 6, "Average result: nothing done.");
        }
        else if (ProblemsSolved == 2)
        {
            return new ExamResult(6, 2, 6, "Average result: nothing done.");
        }

        throw new ArgumentException("Invalid number of problems solved!");
    }
}
