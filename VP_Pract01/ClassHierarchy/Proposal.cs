namespace ClassHierarchy
{
    public class Proposal
    {
        private string _code;
        private string _title;
        private string _text;
        private DateOnly _date;
        private StatusProposal status = StatusProposal.Waiting;

        public void View() { }
        public void ViewStatus() { }
        public void Update() { }
        public void Delete() { }
        public void ArchiveReports() { }
        public void ViewApplicant() { }
    }
}
