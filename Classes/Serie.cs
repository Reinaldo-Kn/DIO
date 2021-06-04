namespace Series
{
    public class Serie : BaseEntity
    {
        private Gender Gender { get; set;}
        private string Title {get;set;}
        private string Description {get;set;}
        private int Year {get;set;}
        private bool isDelete {get;set;}
        public Serie(int id, Gender gender,string title, string description, int year)
        {
            this.Id = id;
            this.Gender = gender;
            this.Title = title;
            this.Description = description;
            this.Year = year;
            this.isDelete = false;
        }
        public override string ToString()
        {
            string retorn = "";
            retorn += "Gender: " + this.Gender + Environment.NewLine;
            retorn += "Title: " + this.Title + Environment.NewLine;
            retorn += "Description: " + this.Description + Environment.NewLine;
            retorn += "Year: " + this.Year;
            return retorn;
        }

        public string returnTitle(){
            return this.Title;
        }
        public int returnId(){
            return this.Id;
        }
        public void isDeleted(){
            this.isDelete = true;
        }
    }
}