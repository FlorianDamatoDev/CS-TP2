using System;

namespace Car {

//------- Classes et fonctions bases -------//

//-------//
// EXO 1 //
//-------//

    class Voiture {
        public string? brand;
        public string? model;
        public int nbDoors;
        public string? color;

        public string Description() {
            return $"La voiture est une {brand} {model} avec {nbDoors} portes de couleur {color}.";
        }
    }

//-------//
// EXO 2 //
//-------//

    class Etudiant {
        public string? name;
        public string? firstName;
        public int age;

        public string Saluer() {
            return $"Bonjour, je m'appelle {name} {firstName} et j'ai {age} ans.";
        }
    }

//-------//
// EXO 3 //
//-------//

    class CompteBancaire {
        public string? nameTitular;
        public float balance;

        public void Deposer(float amount) {
            balance =+ amount;
        }

        public void Retirer(float amount) {
            if (balance - amount >= 0) {
                balance -= amount;
            } else {
                Console.WriteLine("Error: insufficient balance");
            }
        }
    }

//-------//
// EXO 4 //
//-------//

    class Calculatrice {
        public float Additionner(float a, float b) {
            return a + b;
        }

        public float Multiplier(float a, float b) {
            return a * b;
        }
    }

//-------//
// EXO 5 //
//-------//

    class Rectangle {
        public float width;
        public float height;

        public float Aire() {
            return width * height;
        }

        public float Perimetre() {
            return (width + height) * 2;
        }
    }

//------- Classes : héritage et interface -------//

//-------//
// EXO 1 //
//-------//

    interface IVolant {
        string Voler();
    }
    class Oiseau : IVolant {
        public string? name;
        public string Voler() {
            return "Je suis en train de voler !";
        }
        public string Description() {
            return "Je suis un oiseau de nom " + name + ".";
        }
    }

    class Avion : Oiseau, IVolant {
        public int nbMotors;
        public new string Voler() {
            return "Je suis en train de voler !";
        }
        public new string Description() {
            return "Je suis un avion avec " + nbMotors + " moteurs de nom " + name + ".";
        }
    }
    
//-------//
// EXO 2 //
//-------//

    interface IAnimal {
        string Crier();
    }
    class Chat : IAnimal {
        public string? name;
        public string Crier() {
            return "Miaou !";
        }
        public string Description() {
            return "Je suis un chat de nom " + name + ".";
        }
    }
    class Lion : Chat, IAnimal {
        public float weight;
        public new string Crier() {
            return "GRAOU !";
        }
        public new string Description() {
            return "Je suis un lion de nom " + name + " et de poids " + weight + ".";
        }
    }

//-------//
// EXO 3 //
//-------//
    
    class Forme {
        public string? color;
        public virtual float Aire() {
            return 0;
        }
    }
    class Cercle : Forme {
        public float ray;
        const double PI = 3.14;
        public override float Aire() {
            return (float) (PI * ray * ray);
        }
    }
    class Rectangle2 : Forme {
        public float width;
        public float height;
        public override float Aire() {
            return width * height;
        }
    }

//------- Studies -------//

    class EtudiantsStudies {
        public string? name { get; set; }
        public string? firstName { get; set; }
        public int age { get; set; }
        public EtudiantsStudies(string name, string firstName, int age) {
            this.name = name;
            this.firstName = firstName;
            this.age = age;
        }
        public string ReturnFullName() {
            return firstName + " " + name;
        }
    }
    class Formation {
        public List<Etudiant> Students { get; set; }
        public Formation() {
            Students = new List<Etudiant>();
        }
        public float AverageAge() {
            float totalAge = 0;
            foreach (Etudiant student in Students) {
                totalAge += student.age;
            }
            return totalAge / Students.Count;
        }
    }

    class Program {
        public static void Main(string[] args) {
            Clear();
            Console.WriteLine("Choisir une partie :");
            Console.WriteLine("1. Part 1");
            Console.WriteLine("2. Part 2");
            Console.Write("\r\nSelectionner une partie :");

            switch (Console.ReadLine()) {
                case "1":
                    Clear();
                    Part1();
                    break;
                case "2":
                    Clear();
                    Part2();
                    break;
                default:
                    break;
            }
        }

        static void Clear() {
            Console.Clear();
        }

        static void Part1() {
            Clear();
            Console.WriteLine("Choisir un exercice :");
            Console.WriteLine("1. Exercice 1 (Create a Car class)");
            Console.WriteLine("2. Exercice 2 (Create a Student class)");
            Console.WriteLine("3. Exercice 3 (Create a BankAccount class)");
            Console.WriteLine("4. Exercice 4 (Create a Calculator class)");
            Console.WriteLine("5. Exercice 5 (Create a Rectangle class)");
            Console.Write("\r\nChoisir un exercice :");

            switch (Console.ReadLine()) {
                case "1":
                    Clear();
                    Exercice1();
                    break;
                case "2":
                    Clear();
                    Exercice2();
                    break;
                case "3":
                    Clear();
                    Exercice3();
                    break;
                case "4":
                    Clear();
                    Exercice4();
                    break;
                case "5":
                    Clear();
                    Exercice5();
                    break;
                default:
                    break;
            }
        }

        static void Part2() {
            Clear();
            Console.WriteLine("Choisir un exercice :");
            Console.WriteLine("1. Exercice 6 (IVolant interface)");
            Console.WriteLine("2. Exercice 7 (IAnimal interface)");
            Console.WriteLine("3. Exercice 8 (Class Form)");
            Console.WriteLine("4. Exercice 9 (Studies)");
            Console.Write("\r\nSelectionner un exercice :");

            switch (Console.ReadLine()) {
                case "1":
                    Clear();
                    Exercice6();
                    break;
                case "2":
                    Clear();
                    Exercice7();
                    break;
                case "3":
                    Clear();
                    Exercice8();
                    break;
                case "4":
                    Clear();
                    Exercice9();
                    break;
                default:
                    break;
            }
        }

//------- Classes et fonctions bases -------//


//-------//
// EXO 1 //
//-------//

        static void Exercice1() {
            Voiture myCar = new Voiture();
            myCar.brand = "Ford";
            myCar.model = "Focus ST";
            myCar.nbDoors = 5;
            myCar.color = "Blanche";
            Console.WriteLine(myCar.Description());
        }

//-------//
// EXO 2 //
//-------//

        static void Exercice2() {
            Etudiant myStudent = new Etudiant();
            myStudent.name = "Florian";
            myStudent.firstName = "D\'Amato";
            myStudent.age = 20;
            Console.WriteLine(myStudent.Saluer());
        }

//-------//
// EXO 3 //
//-------//

        static void Exercice3() {
            CompteBancaire myAccount = new CompteBancaire();
            myAccount.nameTitular = "Florian";
            myAccount.balance = 2000;
            myAccount.Deposer(1200);
            myAccount.Retirer(1000);
        }

//-------//
// EXO 4 //
//-------//

        static void Exercice4() {
            Calculatrice myCalculator = new Calculatrice();
            Console.WriteLine(myCalculator.Additionner(10, 20));
            Console.WriteLine(myCalculator.Multiplier(10, 20));
        }

//-------//
// EXO 5 //
//-------//

        static void Exercice5() {
            Rectangle myRectangle = new Rectangle();
            myRectangle.width = 10;
            myRectangle.height = 20;
            Console.WriteLine(myRectangle.Aire());
            Console.WriteLine(myRectangle.Perimetre());
        }    
    

//------- Classes : héritage et interface -------//

//-------//
// EXO 1 //
//-------//

        static void Exercice6() {
            Oiseau myBird = new Oiseau();
            myBird.name = "Tourterelle";
            Console.WriteLine(myBird.Voler());
            Console.WriteLine(myBird.Description());

            Avion monAvion = new Avion();
            monAvion.name = "132";
            monAvion.nbMotors = 4;
            
            Console.WriteLine(monAvion.Voler());
            Console.WriteLine(monAvion.Description());
        }
    
//-------//
// EXO 2 //
//-------//

        static void Exercice7() {
            Chat myCat = new Chat();
            myCat.name = "LeChat";
            Console.WriteLine(myCat.Crier());
            Console.WriteLine(myCat.Description());

            Lion myLion = new Lion();
            myLion.name = "Simba";
            myLion.weight = 200;

            Console.WriteLine(myLion.Crier());
            Console.WriteLine(myLion.Description());
        }

//-------//
// EXO 3 //
//-------//

        static void Exercice8() {
            Forme myForm = new Forme();
            myForm.color = "blue";
            Console.WriteLine("Color shape " + myForm.color + " with area " + myForm.Aire());

            Cercle myCircle = new Cercle();
            myCircle.color = "red";
            myCircle.ray = 4;
            Console.WriteLine("Circle of color " + myCircle.color + " with area " + myCircle.Aire());
       
            Rectangle2 myRectangle = new Rectangle2();
            myRectangle.color = "yellow";
            myRectangle.width = 2;
            myRectangle.height = 6;
            Console.WriteLine("Rectangle of color " + myRectangle.color + " with area " + myRectangle.Aire());
        
            int Carre(int x) {
                return x * x;
            }
            int myNumber = 5;
            Console.WriteLine("Square of " + myNumber + " = " + Carre(myNumber));

        }

//-------//
// EXO 4 //
//-------//
    
        static void Exercice9() {
            EtudiantsStudies myStudent = new EtudiantsStudies("D\'Amato", "Florian", 20);
            Console.WriteLine(myStudent.ReturnFullName());

            float AverageAge(List<EtudiantsStudies> students) {
                float totalAge = 0;
                foreach (EtudiantsStudies student in students) {
                    totalAge += student.age;
                }
                return totalAge / students.Count;
            }
        }
    }
}