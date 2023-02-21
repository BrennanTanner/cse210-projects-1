public class ReflectionActivity : Activity
{
    private List<string> _promptList;
    private List<string> _reflectList;
    private Random _random = new Random();
    // List<> list = new List<>();
    public ReflectionActivity(string activity, string description) : base(activity, description)
    {

        _promptList = new List<string>()
            {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
            "When you have something in mind, press enter to continue."
            };

        _reflectList = new List<string>
            {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
            };


    }
    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        // Create an index attribute (variable) to store the random int
        // Call the rnd.Next( _promptList.Count() ) method inside of the rnd object and store it inside of the index attribute
        int index = rnd.Next(_promptList.Count());
        _duration -= 10;
        return _promptList[index];
    }
    public string GetRandomQuestion()
    {
        Random rnd = new Random();
        int index = rnd.Next(_reflectList.Count());
        _duration -= 10;
        return _reflectList[index];

    }
    //Method (Access Type) (Return Type) (Name)
    public void Reflect()
    {
        //     GetRandomPrompt()
        foreach (string prompt in _promptList)
        {

            Console.WriteLine(prompt);

            Console.WriteLine("When you have something in mind, press enter to continue:");
            string userInput = Console.ReadLine();
            if (userInput == "")
            {
                // GetRandomRQuestion()
                foreach (string reflect in _reflectList)
                {
                    Console.WriteLine(reflect);
                    //      Use timer
                    PausewithTimer(10);
                    Console.ReadLine();
                    // how do I make sure that it goes through the whole list before duplicating a question?
                }
            }

            //     while loop (run this loop while duration is greater than 0)
            while (_duration > 0)
            {
                GetRandomQuestion();
                //   add timer for reflecting (ex. pause for 10)
                PausewithTimer(10);
                Console.WriteLine();
                // decriment duration (ex -= 10)
                _duration -= 10;
            }
        }

    }
}
//  The activity should begin with the standard starting message and prompt for the duration that is used by all activities.
// The description of this activity should be something like: "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
// After the starting message, select a random prompt to show the user such as:

// Think of a time when you stood up for someone else.
// Think of a time when you did something really difficult.
// Think of a time when you helped someone in need.
// Think of a time when you did something truly selfless.
// When you have something in mind, press enter to continue.
// Now ponder on each of the following questions as they related to this experience. You may begin in: 
// After displaying the prompt, the program should ask the to reflect on questions that relate to this experience. These questions should be pulled from a list such as the following:

// Why was this experience meaningful to you?
// Have you ever done anything like this before?
// How did you get started?
// How did you feel when it was complete?
// What made this time different than other times when you were not as successful?
// What is your favorite thing about this experience?
// What could you learn from this experience that applies to other situations?
// What did you learn about yourself through this experience?
// How can you keep this experience in mind in the future?
//After each question the program should pause for several seconds before continuing to the next one. While the program is paused it should display a kind of spinner. How did you feel when it was complete?
// It should continue showing random questions until it has reached the number of seconds the user specified for the duration. What is your favorite things about this experience?
// The activity should conclude with the standard finishing message for all activities. Well done!!