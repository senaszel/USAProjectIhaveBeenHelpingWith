using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USAquiz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Quiz introduction
            string title = "Engineering 115: Introduction to Computing for Engineers";
            Console.WriteLine(title);
            Console.WriteLine("Fluorescent Penetrant Level II Quiz");
            Console.WriteLine("Press any key to begin the quiz.");
            Console.ReadKey();
            //Start loop for questions
            AskQuestions();

            Console.ReadLine();
            Console.WriteLine("\n\tThank you for taking test.");
            Console.ReadLine();
        }

        private static void Results(int ok, int nok)
        {
            Console.Clear();
            Console.WriteLine("Correct answers given: " + ok);
            Console.WriteLine("Incorrect answers given: " + nok);
        }

        public static void AskQuestions(bool showResults = false)
        {
            int ok = 0;
            int nok = 0;

            bool question_answered_correctly1 = false;
            bool question_answered_correctly2 = false;
            bool question_answered_correctly3 = false;
            bool question_answered_correctly4 = false;
            bool question_answered_correctly5 = false;
            bool question_answered_correctly6 = false;
            bool question_answered_correctly7 = false;
            bool question_answered_correctly8 = false;
            bool question_answered_correctly9 = false;
            bool question_answered_correctly10 = false;

            for (int i = 1; i <= 2; i++)
            {
                if (i == 2)
                {
                    showResults = true;
                }

                //Question 1
                if (!question_answered_correctly1)
                {
                    //AskQuestion("Question 1: \nWhich of the following is an advantage of FPI? ",
                    //    "Large areas can be inspected",
                    //    "Parts with complex shape can be inspected",
                    //    "It is portable",
                    //    "All of the above",
                    //    'D', ref question_answered_correctly1);//If question is answered correctly changes value to true
                    PrepareQuestion("Question1", ref question_answered_correctly1);
                }
                //Question 2
                if (!question_answered_correctly2)
                {
                    //AskQuestion("Question 2: \nWhich type of penetrant is fluorescent penetrant?",
                    //    "Type I",
                    //    "Type II",
                    //    "Type III",
                    //    "Type IV",
                    //    'A',
                    //    ref question_answered_correctly2);
                    PrepareQuestion("Question2", ref question_answered_correctly2);

                }
                //Question 3
                if (!question_answered_correctly3)
                {
                    //AskQuestion("Question 3: \nWhich method of penetrant removal is water washable?",
                    //    "Method A",
                    //    "Method B",
                    //    "Method C",
                    //    "Method D",
                    //    'A',
                    //    ref question_answered_correctly3);
                    PrepareQuestion("Question3", ref question_answered_correctly3);

                }
                //Question 4
                if (!question_answered_correctly4)
                {
                    //AskQuestion("Question 4: \nWhich developer form is used for nonaqueous Type I developer?",
                    //    "form a",
                    //    "form b",
                    //    "form c",
                    //    "form d",
                    //    'D',
                    //    ref question_answered_correctly4);
                    PrepareQuestion("Question4", ref question_answered_correctly4);

                }
                //Question 5
                if (!question_answered_correctly5)
                {
                    //AskQuestion("Question 5: \nWhich of the following discontinuities can be found by the penetrant test method?",
                    //    "A surface crack",
                    //    "A subsurface crack",
                    //    "An internal inclusion",
                    //    "None of the above",
                    //    'A',
                    //    ref question_answered_correctly5);
                    PrepareQuestion("Question5", ref question_answered_correctly5);

                }
                //Question 6
                if (!question_answered_correctly6)
                {
                    //AskQuestion("Question 6: \nThe term used to define the period of time in which the test part is covered with penetrant is:",
                    //    "waiting time",
                    //    "soak time",
                    //    "dwell time",
                    //    "bleed-in-time",
                    //    'C',
                    //    ref question_answered_correctly6);
                    PrepareQuestion("Question6", ref question_answered_correctly6);

                }
                //Question 7
                if (!question_answered_correctly7)
                {
                    //AskQuestion("Question 7: \nUsually, the most desirable method of removing excess water-washable penetrant after the dwell time is by:",
                    //    "a low pressure coarse water spray",
                    //    "water and brush",
                    //    "a solid stream of water",
                    //    "water and clean rags",
                    //    'A',
                    //    ref question_answered_correctly7);
                    PrepareQuestion("Question7", ref question_answered_correctly7);

                }
                //Question 8
                if (!question_answered_correctly8)
                {
                    //AskQuestion("Question 8: \nWhich of the following discontinuities is most likely to be missed due to improper rinse techniques?",
                    //    "Forging laps",
                    //    "Deep pitting",
                    //    "Shallow and broad discontinuities",
                    //    "The rinse technique will not affect the detection of discontinuities",
                    //    'C',
                    //    ref question_answered_correctly8);
                    PrepareQuestion("Question8", ref question_answered_correctly8);

                }
                //Question 9
                if (!question_answered_correctly9)
                {
                    //AskQuestion("Question 9: \nCapillary action is the tendancy of certain liquids to penetrate into small openings such as cracks or fissures.",
                    //    "True",
                    //    "False",
                    //    " ",
                    //    " ",
                    //    'A',
                    //    ref question_answered_correctly9);
                    PrepareQuestion("Question9", ref question_answered_correctly9);

                }
                //Question 10
                if (!question_answered_correctly10)
                {
                    //AskQuestion("Question 10: \nThe terms dry, aqueous, and nonaqueous are used to describe cleaners.",
                    //    "True",
                    //    "False",
                    //    " ",
                    //    " ",
                    //     'B',
                    //     ref question_answered_correctly10);
                    PrepareQuestion("Question10", ref question_answered_correctly10);

                }


                if (showResults)//This tallys the correct and incorrect answers
                {
                    if (question_answered_correctly1) { ok++; } else nok++;
                    if (question_answered_correctly2) { ok++; } else nok++;
                    if (question_answered_correctly3) { ok++; } else nok++;
                    if (question_answered_correctly4) { ok++; } else nok++;
                    if (question_answered_correctly5) { ok++; } else nok++;
                    if (question_answered_correctly6) { ok++; } else nok++;
                    if (question_answered_correctly7) { ok++; } else nok++;
                    if (question_answered_correctly8) { ok++; } else nok++;
                    if (question_answered_correctly9) { ok++; } else nok++;
                    if (question_answered_correctly10) { ok++; } else nok++;

                    Results(ok, nok);
                }
            }
        }

        private static void PrepareQuestion(string question, ref bool question_answered_correctly)
        {
            string[] questions =
               { "Question 1: \nWhich of the following is an advantage of FPI? ",
                  "Question 2: \nWhich type of penetrant is fluorescent penetrant?",
                  "Question 3: \nWhich method of penetrant removal is water washable?",
                  "Question 4: \nWhich developer form is used for nonaqueous Type I developer?",
                  "Question 5: \nWhich of the following discontinuities can be found by the penetrant test method?",
                  "Question 6: \nThe term used to define the period of time in which the test part is covered with penetrant is:",
                  "Question 7: \nUsually, the most desirable method of removing excess water-washable penetrant after the dwell time is by:",
                  "Question 8: \nWhich of the following discontinuities is most likely to be missed due to improper rinse techniques?",
                  "Question 9: \nCapillary action is the tendancy of certain liquids to penetrate into small openings such as cracks or fissures.",
                  "Question 10: \nThe terms dry, aqueous, and nonaqueous are used to describe cleaners."};
            string[] answers =
                 {"Large areas can be inspected","Parts with complex shape can be inspected","It is portable","All of the above",
                 "Type I","Type II ","Type III ","Type IV",
                 "Method A", "Method B", "Method C", "Method D",
                 "form a", "form b", "form c", "form d",
                 "A surface crack", "A subsurface crack", "An internal inclusion", "None of the above",
                 "waiting time", "soak time", "dwell time", "bleed-in-time",
                 "a low pressure coarse water spray", "water and brush", "a solid stream of water", "water and clean rags",
                 "Forging laps", "Deep pitting", "Shallow and broad discontinuities", "The rinse technique will not affect the detection of discontinuities",
                 "True", "False", " ", " ",
                 "True", "False", " ", " "};
            char[] correct =
             {'D', 'A', 'A', 'D', 'A', 'C', 'A', 'C', 'A', 'B'};

            string tempQuestionNumber = string.Empty;
            for (int i = 0; i < question.Length; i++)
            {
                if (char.IsDigit(question[i]))
                {
                    tempQuestionNumber += question[i];
                }
            }
            int questionNumber = int.Parse(tempQuestionNumber);

            AskQuestion(questions[questionNumber - 1],
                        answers[((questionNumber - 1) * 4)],
                        answers[((questionNumber - 1) * 4) + 1],
                        answers[((questionNumber - 1) * 4) + 2],
                        answers[((questionNumber - 1) * 4) + 3],
                        correct[questionNumber - 1],
                        ref question_answered_correctly);
        }

        //This method prints the question and the possible answers. Next it takes answer and compare it with correct one.
        private static void AskQuestion(string question, string answerA, string answerB, string answerC, string answerD, char correct, ref bool AnsweredCorrectly)
        {
            Console.Clear();
            List<string> list = new List<string>() { answerA, answerB, answerC, answerD };
            ShowQuestion(question, list, 0);
            EnableInteraction(question, list, out ConsoleKey choice);
            CheckAnswer(question, choice, correct, ref AnsweredCorrectly, answerA, answerB, answerC, answerD);
        }

        private static void ShowQuestion(string question, List<string> listOfPossibleAnswers, int pointerPlace)
        {
            string temp = string.Empty;
            listOfPossibleAnswers[pointerPlace] += "  <<<";
            Console.Clear();
            Console.WriteLine(question);
            Console.WriteLine();
            if (listOfPossibleAnswers[0].EndsWith("  <<<"))
            {
                temp = listOfPossibleAnswers[0];
                listOfPossibleAnswers[0] = listOfPossibleAnswers[0].Substring(0, listOfPossibleAnswers[0].Length - 5);
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine(string.Concat("A\t", listOfPossibleAnswers[0]));
                listOfPossibleAnswers[0] = temp;
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine(string.Concat("A\t", listOfPossibleAnswers[0]));
            }
            if (listOfPossibleAnswers[1].EndsWith("  <<<"))
            {
                temp = listOfPossibleAnswers[1];
                listOfPossibleAnswers[1] = listOfPossibleAnswers[1].Substring(0, listOfPossibleAnswers[1].Length - 5);
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine(string.Concat("B\t", listOfPossibleAnswers[1]));
                listOfPossibleAnswers[1] = temp;
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine(string.Concat("B\t", listOfPossibleAnswers[1]));
            }

            if (listOfPossibleAnswers[2] != " ")
            {
                if (listOfPossibleAnswers[2].EndsWith("  <<<"))
                {
                    temp = listOfPossibleAnswers[2];
                    listOfPossibleAnswers[2] = listOfPossibleAnswers[2].Substring(0, listOfPossibleAnswers[2].Length - 5);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine(string.Concat("C\t", listOfPossibleAnswers[2]));
                    listOfPossibleAnswers[2] = temp;
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine(string.Concat("C\t", listOfPossibleAnswers[2]));
                }
            }
            if (listOfPossibleAnswers[3] != " ")
            {
                if (listOfPossibleAnswers[3].EndsWith("  <<<"))
                {
                    temp = listOfPossibleAnswers[3];
                    listOfPossibleAnswers[3] = listOfPossibleAnswers[3].Substring(0, listOfPossibleAnswers[3].Length - 5);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine(string.Concat("D\t", listOfPossibleAnswers[3]));
                    listOfPossibleAnswers[3] = temp;
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine(string.Concat("D\t", listOfPossibleAnswers[3]));
                }
            }
        }

        private static void EnableInteraction(string question, List<string> listOfPossibleAnswers, out ConsoleKey choice, int pointerPlace = 0)
        {
            do
            {
                for (int i = 0; i < listOfPossibleAnswers.Count; i++)
                {
                    if (listOfPossibleAnswers[i].EndsWith("<<<"))
                    {
                        listOfPossibleAnswers[i] = listOfPossibleAnswers[i].Substring(0, listOfPossibleAnswers[i].Count() - 5);
                    }
                }

                choice = Console.ReadKey(true).Key;
                switch (choice)
                {
                    case ConsoleKey.UpArrow:
                        if (pointerPlace - 1 > -1)
                        {
                            pointerPlace--;
                        }
                        else
                        {
                            pointerPlace = 0;
                        }
                        ShowQuestion(question, listOfPossibleAnswers, pointerPlace);
                        break;
                    case ConsoleKey.DownArrow:
                        if (pointerPlace + 1 < listOfPossibleAnswers.Count())
                        {
                            pointerPlace++;
                        }
                        else
                        {
                            pointerPlace = listOfPossibleAnswers.Count - 1;
                        }
                        ShowQuestion(question, listOfPossibleAnswers, pointerPlace);
                        break;
                    case ConsoleKey.Enter:
                        switch (pointerPlace)
                        {
                            case 0:
                                choice = ConsoleKey.A;
                                break;
                            case 1:
                                choice = ConsoleKey.B;
                                break;
                            case 2:
                                choice = ConsoleKey.C;
                                break;
                            case 3:
                                choice = ConsoleKey.D;
                                break;
                        }
                        break;
                }

            } while (
                    choice == ConsoleKey.Enter ||
                    choice == ConsoleKey.UpArrow ||
                    choice == ConsoleKey.DownArrow
                    );
        }

        private static void CheckAnswer(string question, ConsoleKey choice, char correct, ref bool answeredCorrectly, string answerA, string answerB, string answerC, string answerD)
        {
            if (answerC != " " && answerD != " ")
            {
                if (choice == ConsoleKey.A ||
                    choice == ConsoleKey.B ||
                    choice == ConsoleKey.C ||
                    choice == ConsoleKey.D)
                {
                    AllowedInput(choice, correct, ref answeredCorrectly);
                }
                else
                {
                    WrongInput(question, answerA, answerB, answerC, answerD, correct, ref answeredCorrectly);
                }
            }
            else
            {
                if (choice == ConsoleKey.A ||
                    choice == ConsoleKey.B)
                {
                    AllowedInput(choice, correct, ref answeredCorrectly);
                }
                else
                {
                    WrongInput(question, answerA, answerB, answerC, answerD, correct, ref answeredCorrectly);
                }
            }
        }

        private static void AllowedInput(ConsoleKey choice, char correct, ref bool AnsweredCorrectly)
        {
            if (choice.ToString().ToUpper() == correct.ToString().ToUpper())
            {
                AnsweredCorrectly = true;
                Console.WriteLine("\n\tYou answered " + choice + ". That is correct!");
                Console.ReadKey(true);
            }
            else
            {
                Console.WriteLine("\n\tYou answered " + choice + ". That is incorrect.");
                Console.ReadKey(true);
            }
        }

        private static void WrongInput(string question, string answerA, string answerB, string answerC, string answerD, char correct, ref bool AnsweredCorrectly)
        {
            Console.WriteLine("\n\tInvalid input. Try again.");
            Console.Read();
            AskQuestion(question, answerA, answerB, answerC, answerD, correct, ref AnsweredCorrectly);
        }
    }
}