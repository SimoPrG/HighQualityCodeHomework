namespace Exceptions
{
    using System;

    public class CSharpExam : IExam
    {
        private const int MinGrade = 0;
        private const int MaxGrade = 100;
        private int score;

        public CSharpExam(int score)
        {
            this.Score = score;
        }

        public int Score
        {
            get
            {
                return this.score;
            }

            set
            {
                if (value < MinGrade || value > MaxGrade)
                {
                    throw new ArgumentException("The score must be within the range [0; 100].");
                }

                this.score = value;
            }
        }

        public ExamResult Check()
        {
            if (this.Score < MinGrade || this.Score > MaxGrade)
            {
                throw new InvalidOperationException();
            }

            return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
        }
    }
}