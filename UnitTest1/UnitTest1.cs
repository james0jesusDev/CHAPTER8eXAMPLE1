using cHAPTER8eXAMPLE1.Models;
using Xunit;



namespace cHAPTER8eXAMPLE1
{


    public class ACTScoreEvaluatorTest
    {
        private const int HIGH_SCORE = 26;
        private const int LOW_SCORE = 19;
        private const int MEDIOCRE_SCORE = 22;
        private const int INVALID_SCORE = 37;
        private const string ACCEPTED = "Accepted whith high score";
        private const string DENIED = "Rejected whith low score";
        private const string MEDIOCRE = "In process";
        private const string INVALID = "In process";

        [Theory]
        [InlineData(HIGH_SCORE)]

        public void HighACTScoreApplicant(int score)
        {
            var expected = new ACTScoreEvaluator();

            var applicant = new Applicant
            {
                ACTScore = score,
            };
            Assert.Equal(expected.AdmissionEvaluator(applicant), ACCEPTED);
        }

        [Theory]
        [InlineData(LOW_SCORE)]
        public void LowACTScoreApplicant(int score)
        {
            //Arrange
            var expected = new ACTScoreEvaluator();
            //Act
            var applicant = new Applicant
            {
                ACTScore = score
            };
            //Assert
            Assert.Equal(expected.AdmissionEvaluator(applicant), DENIED);
        }
        [Theory]
        [InlineData(MEDIOCRE_SCORE)]
        public void MEDIOCREACTScoreApplicant(int score)
        {
            //Arrange
            var expected = new ACTScoreEvaluator();
            //Act
            var applicant = new Applicant
            {
                ACTScore = score
            };
            //Assert
            Assert.Equal(expected.AdmissionEvaluator(applicant), MEDIOCRE);
        }
        [Theory]
        [InlineData(INVALID_SCORE)]
        public void InvalidACTScoreApplicant(int score)
        {
            //Arrange
            var expected = new ACTScoreEvaluator();
            //Act
            var applicant = new Applicant
            {
                ACTScore = score
            };
            //Assert
            Assert.Equal(expected.AdmissionEvaluator(applicant), INVALID);
        }


    }


}
