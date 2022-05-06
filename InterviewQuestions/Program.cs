// See https://aka.ms/new-console-template for more information

using InterviewQuestions.GeotabQuestions;
using InterviewQuestions.KlickOnlineTest;
using InterviewQuestions.ProgrammingSkills;
using InterviewQuestions.TopInterviewQuestions;

// Display solutions for Programming Skills
//ProgrammingSkills.Initialize();

// Display solutions for the TopInterview questions
//TopInterviewQuestions.Initialize();

// Display solutions for the possible questions Geotab will asks.
// GeotabQuestions.Initialize();


var word = "Complete";
//Console.WriteLine(word.Substring(0,3));


//Console.WriteLine("###### The default value of data time.");
//Console.WriteLine(new DateTime());
Console.WriteLine("######### This is beginning of the klick online assessment. ###########");

KlickTest klickTest = new KlickTest();
Console.WriteLine(klickTest.solution("XX.XXX.."));