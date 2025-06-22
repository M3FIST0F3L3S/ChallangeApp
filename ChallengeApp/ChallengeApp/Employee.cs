using ChallengeApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp {



    class Employee {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        private List<int> Score = new List<int>();
        public int Result { get { return this.Score.Sum(); } }
        public Employee(string name, string surname, int age) {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public void AddScore(int score) {
            this.Score.Add(score);
        }
    }

}

