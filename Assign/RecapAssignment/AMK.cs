using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapAssignment
{
    class AMK
    {
        static void UseAMK()
        {
            List<Programme> programmeList = new List<Programme>();
            // Adding programmes to a list
            Programme ict = new Programme("Information and communication technologies", "TTV");
            programmeList.Add(ict);
            Course oop = new Course("Object oriented programming", "TTOS0200");
            Course network = new Course("Network infrastructure", "TTKS0400");
            Course linux = new Course("Object oriented programming", "TTOS0200");
            ict.AddCouresList(oop);
            ict.AddCouresList(network);
            ict.AddCouresList(linux);
            Student pena = new Student("Pena", "Painovoima", "G3256");
            Student make = new Student("Pena", "Painovoima", "G3256");
            Student kirsi = new Student("Pena", "Painovoima", "G3256");
            Student kissa = new Student("Pena", "Painovoima", "G3256");
            Student koira = new Student("Pena", "Painovoima", "G3256");
            oop.addStudentList(pena);
            
            Programme music = new Programme("Music Pedagogue", "KPD");
            Programme logistics = new Programme("Logistics", "TLO");


            programmeList.Add(music);
            programmeList.Add(logistics);
        }
        static void Main(string[] args)
        {
            UseAMK();
        }
    }
}
