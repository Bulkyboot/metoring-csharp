using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoCSharp {
    public class ExerciseCenter {
        Dictionary<string, Action> exercises;

        public ExerciseCenter(Dictionary<string, Action> exercises) {
            this.exercises = exercises;    
        }

        public void SelectAndRun() {
            int i = 1;

            foreach (var exercise in exercises) {
                Console.WriteLine("{0}) {1}", i, exercise.Key);
                i++;
            }

            Console.Write("Enter number (or empty for last)? ");

            int.TryParse(Console.ReadLine(), out int num);
            bool numValid = num > 0 && num <= exercises.Count;
            num = numValid ? num - 1 : exercises.Count - 1;

            string exerciseName = exercises.ElementAt(num).Key;

            Console.Write("\nRunning exercise ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(exerciseName);
            Console.ResetColor();

            Console.WriteLine(String.Concat(
                Enumerable.Repeat("=", exerciseName.Length + 21)) + "\n");

            Action execute = exercises.ElementAt(num).Value;
            try {
                execute();
            } catch(Exception e) {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("An error has occurred: {0}", e.Message);
                Console.ResetColor();

                Console.WriteLine(e.StackTrace);
            }
        }
    }
}