/*
Etter den andre uken skal du kunne løse denne oppgaven

Her er et javascript obj - gjør det om til en klasse i C#

var student = {
navn: “Heibert”,
alder: 42,
kurs: Radiobilkjøring
};

Bruk så denne klassen til å lage flere studenter, og lagre disse i et array eller en List.
Gjør så man kan skrive/velge et kurs i konsollen, og så listes studentene på det valgte kurset ut i konsollen. 
*/


namespace Ukesoppgave_uke2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentCourseChoice();
        }

        
        static void StudentCourseChoice()
        { 
            // Oppretting av nye studenter

            var Nils = new Student(name:"Nils",age:50, course:"painting");
            var Geir = new Student(name: "Geir", age: 43, course: "exercising");
            var Kåre = new Student(name: "Kåre", age: 24, course: "dancing");

            // Oppretting av en ny liste som inkl. alle studenter

            List<Student> studentList = new List<Student>
            {
                Nils, Geir, Kåre
            };

            var courseInput = Console.ReadLine()!.ToLower();
            var foundStudent = false;

            /*
            For hver student i studentLista, hvis studentens course verdi er lik det man skrev inn i konsollen
            - Skriv i konsollen en infotekst og den relevante studentens navn.
            - Sett foundStudent = true.
            */
            

            foreach (var student in studentList)
            {
                if (student.Course == courseInput)
                {
                    Console.WriteLine($"Here are the people who are in that course:\n {student.Name}");
                    foundStudent = true;
                }
            }

            // Hvis foundStudent ikke er sann så skriv i konsollen at den hobbyen ikke finnes.

            if (!foundStudent)
            {
                Console.WriteLine("That hobby doesn't exist");
            }
        }
    }
}