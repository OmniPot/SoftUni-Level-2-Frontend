namespace StudentClass
{
    using System;

    public class Student
    {
        private int age;
        private string name;

        public Student(string name, int age)
        {
            this.Age = age;
            this.Name = name;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                this.OnPropertyChange(this.Age.GetType().Name, this.Age.ToString(), value.ToString());
                this.age = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.OnPropertyChange("Name", this.Name, value);
                this.name = value;
            }
        }

        public void OnPropertyChange(string propertyName, string oldValue, string newValue)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName, oldValue, newValue));
            }
        }
    }
}
