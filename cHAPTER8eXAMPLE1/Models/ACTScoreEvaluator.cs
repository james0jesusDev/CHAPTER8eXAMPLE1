namespace cHAPTER8eXAMPLE1.Models
{
    public class ACTScoreEvaluator
    {
        private const int MAX_ACT_SCORE = 36;
        private const int AUTO_ACCEPTED_THRESHHOLD = 25;
        private const int AUTO_REJECTED_THRESHHOLD = 20;
        private const int MIN_ACT_SCORE = 1;





        public string AdmissionEvaluator(Applicant applicant)
        {
            if (applicant.ACTScore <= MAX_ACT_SCORE
                && applicant.ACTScore > AUTO_ACCEPTED_THRESHHOLD)
            {
                return "Accepted whith high score";
            }
            else if (applicant.ACTScore >= AUTO_REJECTED_THRESHHOLD)
            {
                return "In process";
            }
            else if (applicant.ACTScore >= MIN_ACT_SCORE)
            {
                return "Rejected whith low score";
            }
            else
            {
                return "Invalid ACT Score";
            }
        }

    }
}
